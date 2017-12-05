//Queue FIFO(First in first out) mantığı ile çalışan bir veri yapısıdır.
//enQueue ile ekleme deQueue ile çıkarma işlemi yapılır.
//Elemanlar sona eklenir,çıkarmalar baştan yapılır.
//ekleme yaparken rear ile çıkarma yaparken front ile ilgileniriz.

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Queues
{
    class Queue<T> where T : IComparable
    {
        T[] items;
        int rear, front; //front başı(indis), rear sonu(indis) tutacak.

        public Queue(int size)
        {
            items = new T[size];
            rear = front = -1;
        }

        public void clear()
        {
            rear = front = -1;
        }

        public int size()
        {
            return items.Length;
        }

        public bool isEmpty()
        {
            return rear == front;
        }

        public bool isFull()
        {
            return rear == size() - 1;
        }

        public void enQueue(T val)  // ekleme işlemlerinde rearı 1 arttırız.
        {
            if (isFull())
                throw new Exception("Queue is full!");
            else
            {
                items[++rear] = val;
            }
        }

        public T deQueue()
        {
            if (isEmpty())
                throw new Exception("Queue is empty!");
            else
                return items[++front];
        }

        public void display()
        {
            if (isEmpty())
            {
                throw new Exception("Queue is empty!");
            }
            else
            {
                int temp = front + 1;
                while (temp <= rear) // rear a gelene kadar
                {
                    Console.Write(items[temp++] + "  ");
                }
                Console.WriteLine();
            }

        }
    }
}
