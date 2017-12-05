using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BinarySearchTree
{
    class BinarySearchTree<T> where T : IComparable
    {
        TreeNode<T> root;

        public void InsertRecursively(T val)
        {
            root = InsertRecursively(root, val);

        }

        private TreeNode<T> InsertRecursively(TreeNode<T> tempRoot, T val)
        {
            if (tempRoot == null)
                return new TreeNode<T>(val);
            else
            {
                if (tempRoot.Value.CompareTo(val) == 1)
                    tempRoot.Left = InsertRecursively(tempRoot.Left, val);
                else if (tempRoot.Value.CompareTo(val) == -1)
                    tempRoot.Right = InsertRecursively(tempRoot.Right, val);
                else
                    Console.WriteLine("cift deger hatası");


            }
            return tempRoot;

        }

        public void Insert(T val)
        {
            if (root == null)
                root = new TreeNode<T>(val);
            else
            {
                TreeNode<T> iterator = root;
                TreeNode<T> parent = root;
                while (iterator != null)
                {
                    parent = iterator;
                    if (iterator.Value.CompareTo(val) == 1)
                        iterator = iterator.Left;
                    else if (iterator.Value.CompareTo(val) == -1)
                        iterator = iterator.Right;
                    else
                    {
                        Console.WriteLine("cift değer hatası");
                        return;
                    }

                }
                if (parent.Value.CompareTo(val) == 1)
                    parent.Left = new TreeNode<T>(val);
                else
                    parent.Right = new TreeNode<T>(val);
            }

        }

        public bool SearchRecursive(T val)
        {
            return SearchRecursive(root, val);

        }

        private bool SearchRecursive(TreeNode<T> tempRoot, T val)
        {
            if (tempRoot == null)
                return false;
            else
            {
                if (tempRoot.Value.CompareTo(val) == 1)
                    return SearchRecursive(tempRoot.Left, val);
                else if (tempRoot.Value.CompareTo(val) == -1)
                    return SearchRecursive(tempRoot.Right, val);
                else
                    return true;
            }

        }

        public bool Search(T val)
        {
            TreeNode<T> iterator = root;
            while (iterator != null)
            {
                if (iterator.Value.CompareTo(val) == 1)
                    iterator = iterator.Left;
                else if (iterator.Value.CompareTo(val) == -1)
                    iterator = iterator.Right;
                else
                    return true;

            }
            return false;
        }


        public void Inorder()
        {
            Inorder(root);
            Console.WriteLine();
        }
        void Inorder(TreeNode<T> tempRoot)
        {
            if (tempRoot != null)
            {
                Inorder(tempRoot.Left);
                Console.WriteLine(tempRoot.Value);
                Inorder(tempRoot.Right);
            }

        }
        public void Preorder()
        {
            Preorder(root);
            Console.WriteLine();
        }
        void Preorder(TreeNode<T> tempRoot)
        {
            if (tempRoot != null)
            {
                Console.WriteLine(tempRoot.Value);
                Preorder(tempRoot.Left);
                Preorder(tempRoot.Right);
            }

        }
        public void Postorder()
        {
            Postorder(root);
            Console.WriteLine();
        }
        void Postorder(TreeNode<T> tempRoot)
        {
            if (tempRoot != null)
            {

                Postorder(tempRoot.Left);
                Postorder(tempRoot.Right);
                Console.WriteLine(tempRoot.Value);
            }

        }

        public T FindMax()
        {
            TreeNode<T> iterator = root;
            while (iterator.Right != null)
            {
                iterator = iterator.Right;
            }
            return iterator.Value;
        }
        public T FindMin()
        {
            TreeNode<T> iterator = root;
            while (iterator.Left != null)
            {
                iterator = iterator.Left;
            }
            return iterator.Value;
        }
        public TreeNode<T> FindMin(TreeNode<T> tempRoot)
        {
            if (tempRoot.Left != null)
                return FindMin(tempRoot.Left);
            return tempRoot;

        }
        public TreeNode<T> FindParent(T val)
        {
            if (root == null || root.Value.CompareTo(val) == 0)
                return null;
            else
            {
                TreeNode<T> iterator = root;
                TreeNode<T> parent = root;
                while (iterator.Value.CompareTo(val) != 0)
                {
                    parent = iterator;
                    if (iterator.Value.CompareTo(val) == 1)
                        iterator = iterator.Left;
                    else
                        iterator = iterator.Right;
                }
                return parent;
            }
        }
        public TreeNode<T> FindSuccessor(TreeNode<T> tempNode)
        {
            if (tempNode.Right != null)
            {
                return FindMin(tempNode.Right);
            }
            else
            {
                TreeNode<T> child = tempNode;
                TreeNode<T> parent = FindParent(child.Value);
                while (child == parent.Right && parent != null)
                {
                    child = parent;
                    parent = FindParent(parent.Value);
                }
                return parent;

            }
        }
        public void Delete(T val)
        {
            if (!Search(val))
                Console.WriteLine("Silinecek eleman yok...");
            else
            {
                TreeNode<T> iterator = root;
                TreeNode<T> parent = root;
                bool isLeftChild = true;
                while (iterator.Value.CompareTo(val) != 0)
                {
                    parent = iterator;
                    if (iterator.Value.CompareTo(val) == 1)
                    {
                        iterator = iterator.Left;
                        isLeftChild = true;
                    }
                    else
                    {
                        iterator = iterator.Right;
                        isLeftChild = false;
                    }
                }
                if (iterator.Left == null && iterator.Right == null)//No child
                {
                    if (iterator == root)
                        root = null;
                    else if (isLeftChild)
                        parent.Left = null;
                    else
                        parent.Right = null;
                }
                else if (iterator.Right == null)
                {
                    if (iterator == root)
                        root = iterator.Left;
                    else if (isLeftChild)
                        parent.Left = iterator.Left;
                    else
                        parent.Right = iterator.Left;
                }
                else if (iterator.Left == null)
                {
                    if (iterator == root)
                        root = iterator.Right;
                    else if (isLeftChild)
                        parent.Left = iterator.Right;
                    else
                        parent.Right = iterator.Right;
                }
                else
                {
                    TreeNode<T> successor = FindSuccessor(iterator);
                    //T successorVal = successor.Value;
                    //Delete(successorVal);
                    //iterator.Value = successorVal;
                    Delete(successor.Value);
                    successor.Left = iterator.Left;
                    successor.Right = iterator.Right;
                    if (isLeftChild)
                        parent.Left = successor;
                    else if (!isLeftChild)
                        parent.Right = successor;
                    else
                        root = successor;
                }
            }
        }
       
    
    }
}
