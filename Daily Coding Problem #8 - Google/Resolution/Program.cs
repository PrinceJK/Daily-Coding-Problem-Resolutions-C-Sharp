using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Resolution
{
    class Program
    {
        static void Main(string[] args)
        {
            Node root = new Node(0, new Node(1), new Node(0, new Node(1, new Node(1), new Node(1)), new Node(0)));

            int numberOfUnivalTrees = GetNumberOfUnivalTrees(root);

            Console.WriteLine(numberOfUnivalTrees);
            Console.ReadKey();
        }

        static int GetNumberOfUnivalTrees(Node root)
        {
            int numberOfTrees = 0;

            if (root == null)
            {
                numberOfTrees++;
                return numberOfTrees;
            }

            bool leftMatchesRoot = false;
            bool leftValueIsNull = false;
            bool rightMatchesRoot = false;
            bool rightValueIsNull = false;
            if (root.Left != null)
            {
                numberOfTrees += GetNumberOfUnivalTrees(root.Left);

                if(root.Value == root.Left.Value)
                    leftMatchesRoot = true;
            }
            else
                leftValueIsNull = true;

            if (root.Right != null)
            {
                numberOfTrees += GetNumberOfUnivalTrees(root.Right);

                if (root.Value == root.Right.Value)
                    rightMatchesRoot = true;
            }
            else
                rightValueIsNull = true;

            if (leftMatchesRoot && rightMatchesRoot || leftValueIsNull && rightValueIsNull)
            {
                numberOfTrees++;
            }


            return numberOfTrees;
        }
    }

    public class Node
    {
        public Node(int value, Node left = null, Node right = null)
        {
            this.Value = value;
            this.Left = left;
            this.Right = right;
        }

        public int Value { get; set; }

        public Node Left { get; set; }

        public Node Right { get; set; }
    }

}