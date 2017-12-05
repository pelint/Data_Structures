using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VYD20102015
{
    class Test
    {
        static void Main(string[] args)
        {
            LinkedList<int> list = new LinkedList<int>();
            list.AddToEnd(3);
            list.AddToEnd(5);
            list.AddToEnd(7);
            list.AddToEnd(8);

            list.Display();
            //list.Delete(5);
            list.AddSorted(6);
            list.Display();

            list.Insert(3, 2);
            list.Display();



        }
    }
}
