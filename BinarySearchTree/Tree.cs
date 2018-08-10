using System;
namespace BinarySearchTree
{
    public class Tree
    {
        private Node node;
        private Random random;
        public Tree()
        {
            random = new Random();
            node = new Node(100);
        }


        public void AddToTree()
        {
            Node nodeToCheck;

            int randomInfo = random.Next(0, 200);
            Node newNode = new Node(randomInfo);
            nodeToCheck = node;
            while (nodeToCheck.rightChild != null || nodeToCheck.leftChild != null)
            {
                if (newNode.info >= nodeToCheck.info && nodeToCheck.rightChild != null )
                {
                    nodeToCheck = nodeToCheck.rightChild;
                }
                else if (newNode.info < nodeToCheck.info && nodeToCheck.leftChild != null)
                {
                    nodeToCheck = nodeToCheck.leftChild;
                }
                else
                {
                    break;
                }
            }

            if (newNode.info >= nodeToCheck.info && nodeToCheck.rightChild == null)
            {
                nodeToCheck.rightChild = newNode;
            }

            else if (newNode.info < nodeToCheck.info && nodeToCheck.leftChild == null)
            {
                nodeToCheck.leftChild = newNode;
            }
        }

        public bool SearchTree(int infoValue)
        {
            Node nodeToCheck = node;
            Console.WriteLine($"{nodeToCheck.info}: Root Node");
            while (nodeToCheck.rightChild != null || nodeToCheck.leftChild != null)
            {
                if (infoValue >= nodeToCheck.info && nodeToCheck.rightChild != null)
                {
                    nodeToCheck = nodeToCheck.rightChild;
                    Console.WriteLine($"{nodeToCheck.info}: Went right ->");
                }
                else if (infoValue < nodeToCheck.info && nodeToCheck.leftChild != null)
                {
                    nodeToCheck = nodeToCheck.leftChild;
                    Console.WriteLine($"{nodeToCheck.info}: <- Went left");
                }
                else
                {
                    break;
                }
            }

            if (infoValue ==  nodeToCheck.info)
            {
                Console.WriteLine($"Found the node at {nodeToCheck.info}!");
                return true;
            }
            else
            {
                Console.WriteLine("Could not find this value in the tree.");
                return false;
            }

        }
    }
}
