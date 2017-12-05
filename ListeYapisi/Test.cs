using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ListYapisi
{
    class Test
    {
        static void Main(string[] args)
        {
            ListOp list = new ListOp(6);
            list.AddToEnd(5);
            list.AddToEnd(3);
            list.AddToEnd(1);
            list.AddToEnd(6);
            list.AddToEnd(8);
            //list.display();
            list.insert(2,3);
            list.display();
            //list.delete(3);
            //list.display();
            //list.reverse();
            //list.display();
            //Console.WriteLine(list.Search(5));
            //Console.WriteLine(list.Search(51));

            ListOp list2 = new ListOp(6);
            list2.AddToEnd(5);
            list2.AddToEnd(3);
            list2.AddToEnd(1);
            list2.AddToEnd(2);
            list2.AddToEnd(6);
            list2.AddToEnd(10);
            list2.display();
            Console.WriteLine(list.Equal(list2));

        }
    }
}
