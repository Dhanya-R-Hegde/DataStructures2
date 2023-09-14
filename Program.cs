using static DataStructures2.BinarySearchTree;

namespace DataStructures2
{
    public class Program
    {
        static void Main(string[] args)
        {

            //UserCase1
            //BinarySearchTree binarySearchTree = new BinarySearchTree();
            //int[]values = { 56, 30, 70};
            //Node root = null;

            //for (int i = 0; i < values.Length; i++)
            //{
            //    root = insert(root, values[i]);
            //}

            //inorder(root);
            //Console.WriteLine();
            //Console.WriteLine(Node.size);

            //UserCase2
            //int []values = { 56, 30, 40, 22, 11, 16, 3, 70, 60, 95, 65, 63, 67 };
            //Node root = null;

            //for (int i = 0; i < values.Length; i++)
            //{
            //    root = insert(root, values[i]);
            //}

            //inorder(root);
            //Console.WriteLine();
            //Console.WriteLine(Node.size);

            //UserCase3
            int[]values = { 56, 30, 40, 22, 11, 16, 3, 70, 60, 95, 65, 63, 67 };
            Node root = null;

            for (int i = 0; i < values.Length; i++)
            {
                root = insert(root, values[i]);
            }

            if (search(root, 63))
            {
                Console.WriteLine("Found");
            }
            else
            {
                Console.WriteLine("Not found");
            }
        }
    }
}
 