using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Twitter_Problem_Resolution
{
    class Program
    {
        static void Main(string[] args)
        {
            WordTree wordTree = new WordTree();
            wordTree.AddWord("dog");
            wordTree.AddWord("deer");
            wordTree.AddWord("deal");

            string[] wordsToAutoComplete = wordTree.SearchForWordsToAutoComplete("de");

            for (int i = 0; i < wordsToAutoComplete.Length; i++)
            {
                Console.WriteLine(wordsToAutoComplete[i]);
            }

            Console.ReadKey();
        }
    }

    class WordTree
    {
        Node root = new Node();

        public void AddWord(string word, Node currentNode = null, int currentCharacterIndex = 0)
        {
            if (currentNode == null)
                currentNode = root;

            if (!currentNode.childrenNodes.ContainsKey(word[currentCharacterIndex]))
            {
                currentNode.childrenNodes.Add(word[currentCharacterIndex], new Node(word[currentCharacterIndex]));
            }

            if(currentCharacterIndex != word.Length - 1)
                AddWord(word, currentNode.childrenNodes[word[currentCharacterIndex]], currentCharacterIndex + 1);
            else
            {
                currentNode.childrenNodes[word[currentCharacterIndex]].Word = word;
            }
        }

        public string[] SearchForWordsToAutoComplete(string word)
        {
            Node currentNode = SearchForNode(word);

            string[] wordsFound = SearchForAllWordsContainedInsideANode(currentNode);

            return wordsFound;
        }

        Node SearchForNode(string word)
        {
            Node currentNode = root;

            for (int i = 0; i < word.Length; i++)
            {
                if (currentNode.childrenNodes.ContainsKey(word[i]))
                {
                    currentNode = currentNode.childrenNodes[word[i]];
                }
            }

            return currentNode;
        }

        string[] SearchForAllWordsContainedInsideANode(Node nodeToSearch)
        {
            List<string> wordsFound = new List<string>();

            int numberOfTimesToLoop = nodeToSearch.childrenNodes.Count;
            if (numberOfTimesToLoop == 0) numberOfTimesToLoop++;

            for (int i = 0; i < numberOfTimesToLoop; i++)
            {
                if(nodeToSearch.childrenNodes.Count > 0)
                {
                    char[] keysArray = nodeToSearch.childrenNodes.Keys.ToArray();
                    string[] wordsFoundInsideChildrenNode = SearchForAllWordsContainedInsideANode(nodeToSearch.childrenNodes[keysArray[i]]);

                    for (int j = 0; j < wordsFoundInsideChildrenNode.Length; j++)
                    {
                        wordsFound.Add(wordsFoundInsideChildrenNode[j]);
                    }
                }
                
                if(nodeToSearch.Word != null)
                    wordsFound.Add(nodeToSearch.Word);
            }

            return wordsFound.ToArray();
        }
    }
    

    class Node
    {
        public char Value;
        public string Word;

        public Dictionary<char, Node> childrenNodes = new Dictionary<char, Node>();

        public Node()
        {

        }

        public Node(char value)
        {
            Value = value;
        }
    }
}
