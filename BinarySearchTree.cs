using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataStructures2
{
    internal class BinarySearchTree
    {
        public class Node
        {
            public int data;
            public Node left;
            public Node right;
            public static int size = 0;

            public Node(int data)
            {
                this.data = data;
            }
        }

        public static Node insert(Node root, int val)
        {
            if (root == null)
            {
                root = new Node(val);
                Node.size++;
                return root;
            }

            if (root.data > val)
            {
                root.left = insert(root.left, val);
            }
            else
            {
                root.right = insert(root.right, val);
            }
            return root;
        }

        public static void inorder(Node root)
        {
            if (root == null)
            {
                return;
            }

            inorder(root.left);
            Console.Write(root.data + "  ");
            inorder(root.right);
        }

        public static Boolean search(Node root, int key)
        { //O(H)
            if (root == null)
            {
                return false;
            }
            if (root.data > key)
            {
                return search(root.left, key);
            }
            else if (root.data < key)
            {
                return search(root.right, key);
            }
            else if (root.data == key)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
