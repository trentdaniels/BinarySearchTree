using System;
namespace BinarySearchTree
{
    public class Node
    {
        public Node leftChild;
        public Node rightChild;
        public int info;

        public Node(int info)
        {
            leftChild = null;
            rightChild = null;
            this.info = info;
        }


    }
}
