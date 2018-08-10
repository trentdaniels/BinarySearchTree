using System;
namespace BinarySearchTree
{
    public class Node
    {
        private Node leftChild;
        private Node rightChild;
        private int info;

        public Node LeftChild { get => leftChild; set => leftChild = value; }
        public Node RightChild { get => rightChild; set => rightChild = value; }
        public int Info { get => info; set => info = value; }

        public Node(int info)
        {
            leftChild = null;
            rightChild = null;
            this.info = info;
        }


    }
}
