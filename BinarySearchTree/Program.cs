using System;

namespace BinarySearchTree
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            Tree tree = new Tree();
            for (int i = 0; i < 50; i++)
            {
                tree.AddToTree();
            }

            tree.SearchTree(85);
        }
    }
}
