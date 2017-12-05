using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace HuffmanTree
{
    class HuffmanTree
    {
        HuffmanNode head;
        HuffmanNode root;

        public void addSorted(string value, double frequency)
        {
            addSorted(new HuffmanNode(value, frequency));
        }
        private void addSorted(HuffmanNode newNode)
        {
            if (head == null)
                head = newNode;
            else
            {
                HuffmanNode iterator = head;
                HuffmanNode previous = head;
                while (iterator != null)
                {
                    if ((iterator.Frequency == newNode.Frequency && iterator.Value.CompareTo(newNode.Value) == 1) || (iterator.Frequency > newNode.Frequency))
                    {
                        break;
                    }
                    previous = iterator;
                    iterator = iterator.Next;
                }
                if (iterator == head)
                {
                    head = newNode;
                    head.Next = iterator;

                    //HuffmanNode tempNode= new HuffmanNode(value, frequency);
                    //tempNode.Next = head;
                    //head = tempNode;
                }
                else
                {
                    previous.Next = newNode;
                    previous.Next.Next = iterator;
                }

            }
        }

        public void CreateHuffmanTree()
        {
            while(head != null && head.Next !=null)
            {
                HuffmanNode tempNode = new HuffmanNode(head.Value+head.Next.Value , head.Frequency+head.Next.Frequency);
                tempNode.Left = head;
                tempNode.Right = head.Next;
                head = head.Next.Next;
                addSorted(tempNode);
                Display();
            }
            head = root;
        }

        public string Encode(string text)
        {
            string binaryText = "";
            HuffmanNode iterator = root;
            for (int i = 0; i < text.Length; i++)
            {
                iterator = root;
                while (iterator != null)
                {
                    if (iterator.Value.CompareTo(text[i].ToString()) == 0)
                    {
                        break;
                    }
                    if (iterator.Value.Contains(text[i]))
                    {
                        if (iterator.Left.Value.Contains(text[i]))
                        {
                            binaryText += "0";
                            iterator = iterator.Left;
                        }
                        else
                        {
                            binaryText += "1";
                            iterator = iterator.Right;
                        }
                    }
                }
            }

            return binaryText;
        }

        public string Decode(string binaryText)
        {
            HuffmanNode iterator = root;
            string decodedText = "";
            for (int i = 0; i < binaryText.Length; i++)
            {

                if (binaryText[i] == '0')
                    iterator = iterator.Left;
                else
                    iterator = iterator.Right;
                if (iterator.Left == null && iterator.Right == null)
                {
                    decodedText += iterator.Value;
                    iterator = root;
                }

            }
            return decodedText;

        }

        public void Display()
        {
            HuffmanNode iterator = head;
            while (iterator != null)
            {
                Console.Write("(" + iterator.Value + "," + iterator.Frequency + ") ");
                iterator = iterator.Next;
            }
            Console.WriteLine();
        }

        public bool isDecode(string binaryText)
        {
            HuffmanNode iterator = root;

            try
            {
                for (int i = 0; i < binaryText.Length; i++)
                {

                    if (binaryText[i] == '0')
                        iterator = iterator.Left;
                    else if (binaryText[i] == '0')
                    {
                        iterator = iterator.Right;
                    }

                    if (iterator.Left == null && iterator.Right == null)
                    {
                        iterator = root;
                    }
                }
            

            } 
            catch(Exception e)
            {
                return false;
            }

            return true;
        }

    }
}
