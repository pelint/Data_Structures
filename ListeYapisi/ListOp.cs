using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ListYapisi
{
    class ListOp
    {
        int[] values;
        int last; // dizinin ilk boş yerini belirtir.

        public ListOp(int size)
        {
            values = new int[size];
        }

        public bool isFull() //Liste dolu mu onu kontrol eder.
        {
            return last == values.Length;
        }

        public void AddToEnd(int val) // Listenin sonuna eleman ekleme 
        {
            if (!isFull())
            {
                values[last++] = val;
            }
            else
            {
                Console.WriteLine("Stack Dolu!");
            }
        }

        public void insert(int val,int index)  // Araya eleman ekleme
        {
            if (!isFull())
            {
                if (index > -1 && index < last + 1)
                {
                    for (int i = last; i > index; i--)
                    {
                        values[i] = values[i - 1];
                    }

                    values[index] = val;
                    last++;
                }
            }

            else
            {
                Console.WriteLine("Stack Dolu!");
            } 


        }


        public void display()  // elemanları görüntüleme
        {
            for (int i = 0; i < values.Length; i++)
            {
                Console.Write(values[i]+"  ");
            }
            Console.WriteLine();
        }

        public void delete(int index)
        {
            if (index > -1 && index < last && last > 0)
            {
                for(int i=index; i<last-1;i++)
                {
                    values[i] = values[i+1];
                }
                values[--last] = 0;
            }
        }

        public void reverse() //Dizi içerisindei elemanları ters çevirme
        {
            int temp;
            for (int i = 0; i < (last)/2 ; i++)
            {
                temp = values[i];
                values[i] = values[last-1-i];
                values[last-1 - i] = temp;
            }
        }

        public bool Search(int item)
        {
            for (int i = 0; i < last; i++)
            {
                if (values[i] == item)
                {
                    return true;
                }

            }

            return false;
        }

        public bool Equal(ListOp array)
        {
            if (last == array.last)
            {
                for (int i = 0; i < last; i++)
                {
                    if (values[i] != array.values[i])
                    {
                        return false;
                    }
                }
                return true;
            }
            return false;
        }
    }
}
