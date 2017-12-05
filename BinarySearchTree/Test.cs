using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BinarySearchTree
{
    class Test
    {
        static void Main(string[] args)
        {
            BinarySearchTree<int> bst = new BinarySearchTree<int>();
            bst.Insert(6);
            bst.Insert(5);
            bst.InsertRecursively(68);
            bst.Insert(43);
            bst.Insert(12);
            bst.InsertRecursively(1);
            bst.InsertRecursively(9);
            bst.Inorder();
            //bst.Postorder();
            //Console.WriteLine(bst.FindMin());
            //Console.WriteLine(bst.FindMax());
            //Console.WriteLine();

            //bst.Preorder();
            //Console.WriteLine();
            //bst.Delete(5);
            //bst.Preorder();

       


        }
    }
}
