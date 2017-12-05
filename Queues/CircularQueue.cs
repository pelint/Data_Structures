// circular queue de rear ve frontu arttırırken size() a göre modunu alamamız gerekiyor. (rear+1)%size()
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Queues
{
    class CircularQueue<T> where T : IComparable
    {
        T[] items;
        int front, rear;

        public CircularQueue(int size)
        {
            items = new T[size];
            front = rear = 0;
        }

        public void clear()
        {
            front = rear = 0;
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
            return (rear + 1) % size() == front;
        }

        public void enQueue(T val)
        {
            if (isFull())
                throw new Exception("Circular Queue is Full!");
            else
            {
                rear = (rear + 1) % size();
                items[rear] = val;
            }
        }

        public T deQueue()
        {
            if (isEmpty())
                throw new Exception("Circular Queue is empty!");
            else
            {
                front = (front + 1) % size();
                return items[front];
            }
        }

        public void display()
        {
            if (isEmpty())
                throw new Exception("Circular Queue is emnpty!");
            int temp = front;
            while (temp != rear)
            {
                temp = (temp + 1) % size();
                Console.Write(items[temp] + "  ");
            }

            Console.WriteLine();
        }
    }
}
