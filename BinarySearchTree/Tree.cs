using System;
namespace BinarySearchTree
{
    public class Tree
    {
        private Node rootNode;
        private Random random;
        public Tree()
        {
            random = new Random();
            rootNode = new Node(100);
        }


        public void AddToTree()
        {
            Node nodeToCheck;

            int randomInfo = random.Next(0, 200);
            Node newNode = new Node(randomInfo);
            nodeToCheck = rootNode;
            while (CheckedNodeHasAChild(nodeToCheck))
            {
                if (newNode.Info >= nodeToCheck.Info && nodeToCheck.RightChild != null)
                {
                    nodeToCheck = nodeToCheck.RightChild;
                }
                else if (newNode.Info < nodeToCheck.Info && nodeToCheck.LeftChild != null)
                {
                    nodeToCheck = nodeToCheck.LeftChild;
                }
                else
                {
                    break;
                }
            }

            if (newNode.Info >= nodeToCheck.Info && nodeToCheck.RightChild == null)
            {
                nodeToCheck.RightChild = newNode;
            }

            else if (newNode.Info < nodeToCheck.Info && nodeToCheck.LeftChild == null)
            {
                nodeToCheck.LeftChild = newNode;
            }
        }

        public bool SearchTree(int infoValue)
        {
            Node nodeToCheck = rootNode;
            Console.WriteLine($"Search value: {infoValue}");
            Console.WriteLine($"Root : {nodeToCheck.Info}");
            while (CheckedNodeHasAChild(nodeToCheck))
            {
                if (infoValue >= nodeToCheck.Info && nodeToCheck.RightChild != null)
                {
                    nodeToCheck = nodeToCheck.RightChild;
                    Console.WriteLine($"-> : {nodeToCheck.Info}");
                }
                else if (infoValue < nodeToCheck.Info && nodeToCheck.LeftChild != null)
                {
                    nodeToCheck = nodeToCheck.LeftChild;
                    Console.WriteLine($"<- : {nodeToCheck.Info}");
                }
                else
                {
                    break;
                }
            }

            if (infoValue == nodeToCheck.Info)
            {
                Console.WriteLine($"Found the node at {nodeToCheck.Info}!");
                return true;
            }
            Console.WriteLine($"Could not find {infoValue} in the tree.");
            return false;
        }

        private bool CheckedNodeHasAChild(Node nodeToCheck)
        {
            return nodeToCheck.RightChild != null || nodeToCheck.LeftChild != null;
        }
    }
}
