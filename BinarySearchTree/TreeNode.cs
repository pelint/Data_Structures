using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BinarySearchTree
{
    class TreeNode<T> where T : IComparable
    {
        T value;
        TreeNode<T> left;
        TreeNode<T> right;

        public T Value
        {
            get
            {
                return value;
            }

            set
            {
                this.value = value;
            }
        }

        internal TreeNode<T> Left
        {
            get
            {
                return left;
            }

            set
            {
                left = value;
            }
        }

        internal TreeNode<T> Right
        {
            get
            {
                return right;
            }

            set
            {
                right = value;
            }
        }
        public TreeNode(T val)
        {
            Value = val;
        }


    }
}
