using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Queues
{
    class Test
    {
        static void Main(string[] args)
        {
            Console.WriteLine("---------Queue-------");
            Queue<int> myQueue = new Queue<int>(6);
            myQueue.enQueue(5);
            myQueue.enQueue(2);
            myQueue.enQueue(8);
            myQueue.enQueue(1);
            myQueue.enQueue(3);
            myQueue.enQueue(9);
            myQueue.display();
            myQueue.deQueue();
            myQueue.display();

            Console.WriteLine("---------Circular Queue-------");
            CircularQueue<int> myCircularQueue = new CircularQueue<int>(8);
            myCircularQueue.enQueue(1);
            myCircularQueue.enQueue(9);
            myCircularQueue.enQueue(5);
            myCircularQueue.enQueue(2);
            myCircularQueue.enQueue(8);
            myCircularQueue.enQueue(3);
            myCircularQueue.enQueue(6);
            myCircularQueue.display();
            myCircularQueue.deQueue();
            myCircularQueue.deQueue();
            myCircularQueue.display();



        }
    }
}
