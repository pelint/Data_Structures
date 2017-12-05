using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Stack
{
    class Test
    {
        static void Main(string[] args)
        {
            //Stack<int> myStack = new Stack<int>(8);
            //myStack.Push(12);
            //myStack.Push(9);
            //myStack.Push(1);
            //myStack.Push(19);
            //myStack.Push(30);
            //myStack.display();

            //Console.WriteLine("_______________________________");
            //Console.WriteLine();

            //StackOp<int> stackOp = new StackOp<int>();
            //stackOp.deleteOnlyOne(myStack,1);
            //myStack.display();

            //Console.WriteLine("_______________________________");
            //Console.WriteLine();

            //Stack<int> myStack2 = new Stack<int>(9); // 3,4,1,8,9,21,18,30,2  sayılarını sıralı olarak ekleyelim
            //stackOp.AddInorder(myStack2, 3);
            //stackOp.AddInorder(myStack2, 4);
            //stackOp.AddInorder(myStack2, 1);
            //stackOp.AddInorder(myStack2, 8);
            //stackOp.AddInorder(myStack2, 9);
            //stackOp.AddInorder(myStack2, 21);
            //stackOp.AddInorder(myStack2, 18);
            //stackOp.AddInorder(myStack2, 30);
            //stackOp.AddInorder(myStack2, 2);

            //myStack2.display();


            //Console.WriteLine("_______________________________");
            //Console.WriteLine();

            //Stack<int> myStack3 = new Stack<int>(9); // 3,4,1,8,9,21,18,30,2  sayılarını sıralı olarak ekleyelim
            //myStack3.Push(3);
            //myStack3.Push(13);
            //myStack3.Push(2);
            //myStack3.Push(8);
            //myStack3.Push(1);
            //myStack3.Push(9);
            //myStack3.display();
            //Console.WriteLine("Minimum eleman siliniyor!");
            //stackOp.deleteMin(myStack3);
            //myStack3.display();

            StringOp sOp = new StringOp();

            string exp = "7 a 5 + *";
            string[] result = sOp.seperate(exp);

            for (int i = 0; i < result.Length; i++)  // exp yi parçaladığımızda elde ettiğimiz array in elemanlarını yazdıracak
            {
                Console.WriteLine(result[i]);
            }

            Console.WriteLine();
            Console.WriteLine("15 bir sayı mı?  "+sOp.isNumber("15"));
            Console.WriteLine("1a bir sayı mı?  "+sOp.isNumber("1a"));
            Console.WriteLine("a bir oeratör mü?  "+sOp.isOperator("a"));
            Console.WriteLine();
            Console.WriteLine("Postfix ifadenin sonucu:");
            StackOp<double> stackOp = new StackOp<double>();
            Console.WriteLine(stackOp.calculatePostfix("5 4 3 + * 7 -"));

        }

    }
}
