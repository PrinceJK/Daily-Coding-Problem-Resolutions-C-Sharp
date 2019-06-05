using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BinaryTreeProblemResolution
{
    class Program
    {

        static void Main(string[] args)
        {
            Node node = new Node("root", new Node("left", new Node("left.left")), new Node("right", new Node("right.left"), new Node("right.right")));

            string serializedBinaryTree = SerializeNode(node);
            Node deserializedNode = DeserializeNode(serializedBinaryTree);

            Console.WriteLine(deserializedNode.Value);
            Console.ReadKey();
        }

        static string SerializeNode(Node node)
        {
            if (node == null) return "1-";

            StringBuilder sb = new StringBuilder();

            sb.Append(node.Value + "-");
            sb.Append(SerializeNode(node.Left));
            sb.Append(SerializeNode(node.Right));

            return sb.ToString();
        }

        static int index = 0;
        static Node DeserializeNode(string serializedNode)
        {
            string[] serializedStringArray = serializedNode.Split('-');

            if(serializedStringArray[index] == "1")
            {
                index++;
                return null;
            }

            Node nodeToReturn = new Node(serializedStringArray[index]);
            index++;
            nodeToReturn.Left = DeserializeNode(serializedNode);
            nodeToReturn.Right = DeserializeNode(serializedNode);

            return nodeToReturn;
        }
    }

    class Node
    {
        public string Value;
        public Node Left;
        public Node Right;

        public Node(string value = null, Node left = null, Node right = null)
        {
            Value = value;
            Left = left;
            Right = right;
        }
    }
}