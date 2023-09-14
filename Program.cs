﻿using static DataStructures2.BinarySearchTree;

namespace DataStructures2
{
    public class Program
    {
        static void Main(string[] args)
        {

            //UserCase1
            BinarySearchTree binarySearchTree = new BinarySearchTree();
            int[]values = { 56, 30, 70};
            Node root = null;

            for (int i = 0; i < values.Length; i++)
            {
                root = insert(root, values[i]);
            }

            inorder(root);
            Console.WriteLine();
            Console.WriteLine(Node.size);
        }
    }
}
 