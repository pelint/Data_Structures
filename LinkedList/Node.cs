using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VYD20102015
{
    class Node<T>
    {
        T value;
        Node<T> next;

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
        public Node<T> Next
        {
            get
            {
                return next;
            }

            set
            {
                next = value;
            }
        }

        public Node(T val)
        {
            value = val;
            next = null;
        }

    }
}
