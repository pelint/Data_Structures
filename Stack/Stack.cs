// Stackler, LIFO (Last In First Out = Son giren ilk çıkar) mantığı ile çalışırlar.
// Sadece en son eklenen elemana erişim söz konusu olabilir.
//push:stack sonuna eleman ekleme 
//pop: stack in son elemanını döndürür.

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Stack
{
    class Stack <T>
    {
        T[] values;
        int top;

        public Stack(int size)
        {
            values = new T[size];
            top = -1;
        }

        public bool isEmpty() // stack boş mu
        {
            return top == -1;
        }

        public bool isFull() // stack dolu mu
        {
            return top == values.Length - 1;
        }

        public int count()
        {
            return top + 1;
        }
        public void Push(T val) // stack e eleman ekleme
        {
            if (!isFull())
            {
                values[++top] = val;
            }

            else
            {
                Console.WriteLine("Stack is Full!!");
            }
        }

        public T Pop()  // stack teki en üstteki elemanı döndürme
        {
            if (!isEmpty())
            {
                T temp = values[top--];
                return temp;
            }

            else
            {
                Console.WriteLine("Stack is Empty!!");
                return default(T);
            }
        }

        public void display() // stack teki elemanlerı görüntüleme
        {
            if (!isEmpty())
            {
                for (int i = top; i>-1 ; i--)
                {
                    Console.WriteLine(values[i]);
                }
            }
            else
            {
                Console.WriteLine("Stack is Empty!!");
            }
        }

        public int Size()
        {
            return values.Length;
        }


    }
}
