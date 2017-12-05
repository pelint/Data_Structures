using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace HuffmanTree
{
    class HuffmanNode
    {
        string value;
        double frequency;

        HuffmanNode left, right;
        HuffmanNode next;

        #region encapsulate
        public string Value
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

        public double Frequency
        {
            get
            {
                return frequency;
            }

            set
            {
                frequency = value;
            }
        }

        internal HuffmanNode Left
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

        internal HuffmanNode Right
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

        internal HuffmanNode Next
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

        #endregion

        public HuffmanNode(string value,double frequency)
        {
            Value = value;
            Frequency = frequency;
        }


    }
}
