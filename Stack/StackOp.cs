using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Stack
{ 
    class StackOp<T> where T: IComparable 
    {
       
        public Stack<T> Copy(Stack<T> sourceStack)  // Stack ın kopyasını alma
        {
            Stack<T> tempStack = new Stack<T>(sourceStack.Size());
            Stack<T> copyStack = new Stack<T>(sourceStack.Size());

            while (!sourceStack.isEmpty())
            {
                tempStack.Push(sourceStack.Pop());
            }

            while (!tempStack.isEmpty())
            {
                T temp = tempStack.Pop();
                copyStack.Push(temp);
                sourceStack.Push(temp);
            }

            return copyStack;
        }

        public void deleteOnlyOne(Stack<T> sourceStack, T val)  // stack içerisinden değer silme
        {
            Stack<T> tempStack = new Stack<T>(sourceStack.Size());
            T temp;

            while (!sourceStack.isEmpty())
            {
                temp = sourceStack.Pop();
                if (temp.CompareTo(val) != 0)
                {
                    tempStack.Push(temp);
                }
                else
                {
                    break;
                }
            }

            while (!tempStack.isEmpty())
            {
                sourceStack.Push(tempStack.Pop());
            }
        }


        public void deleteMin(Stack<T> sourceStack) // stack içerisindeki en küçük elemanı siler
        {
            T min, temp;
            Stack<T> tempStack = new Stack<T>(sourceStack.Size());

            if (!sourceStack.isEmpty())
            {
                min = sourceStack.Pop();
                tempStack.Push(min);

                while(!sourceStack.isEmpty())
                {
                    temp = sourceStack.Pop();
                    if(temp.CompareTo(min)==-1)
                    {
                        min = temp;
                    }
                    tempStack.Push(temp);
                }

                while(!tempStack.isEmpty())
                {
                    temp = tempStack.Pop();
                    if(temp.CompareTo(min)!=0)
                    {
                        sourceStack.Push(temp);
                    }
                }
            }
            else
                Console.WriteLine("Stack is Empty!");


        }

        public void AddInorder(Stack<T> sourceStack, T val) //Sıralı bir şekilde stack eleman ekler
        {

            Stack<T> tempStack = new Stack<T>(sourceStack.Size());
            T temp;

            if (!sourceStack.isEmpty()) //stackte eleman varsa
            {

                while (!sourceStack.isEmpty())
                {
            
                    temp = sourceStack.Pop();

                    if (temp.CompareTo(val) == -1)  //eğer stackteki eleman eklenecek değerden küçükse
                    {
                        tempStack.Push(temp); // stackteki elemanı tempStack e at
                    }

                    else   // eşitse ya da büyükse
                    {
                        sourceStack.Push(temp); // elemanı geri bırak
                        break; // ve döngüden çık

                    }
                    
                }

                sourceStack.Push(val); //elemanı yazdır

                if (!tempStack.isEmpty()) //tempstackte eleman varsa
                {
                    while (!tempStack.isEmpty()) 
                    {
                        sourceStack.Push(tempStack.Pop()); // o elemanları stacke geri yazdır.
                    }
                }

            }

            else if(sourceStack.isEmpty()) //stackte hiç elaman yok ise
            {
                sourceStack.Push(val);
            }

            else  // stack dolu ise
            {
                Console.WriteLine("Stack is full!");
            }

        }


        

        public int CompareTo(object obj)
        {
            throw new NotImplementedException();
        }


        public double calculatePostfix(string postfix)   //Parametre olarak gönderilen postfix bir ifadeyi hesaplar
        {
            StringOp sOp = new StringOp();
            string[] result = sOp.seperate(postfix);
            Stack<double> tempStack = new Stack<double>(result.Length);
            double temp;

           

            for(int i=0; i<result.Length; i++)
            {
                if(sOp.isNumber(result[i])) //ifade sayı ise
                {
                    temp = double.Parse(result[i]);
                    tempStack.Push(temp);
                }

                else if(sOp.isOperator(result[i])) //ifade işlem ise
                {
                    double first, second;
                    first = tempStack.Pop();
                    second = tempStack.Pop();

                    switch (result[i])
                    {
                        case "+":
                            {
                                tempStack.Push(first+second);
                                break;
                            }
                        case "-":
                            {
                                
                                tempStack.Push(second-first); //burası önemli! ikinciden birincisi çıkacak!
                                break;
                            }
                        case "*":
                            {
                                tempStack.Push(first * second);
                                break;
                            }
                        case "/":
                            {
                                tempStack.Push(second / first);
                                break;
                            }
                        default:
                            {
                                throw new Exception("invalid postfix expression!");
                            }
                  

                    }
                }

            }

            if (tempStack.count() == 1)  // stackte tek eleman kaldıysa sonuç o değerdir.
                return tempStack.Pop();
            else
                throw new Exception("Result is wrong!"); // birden fazla eleman varsa postficx ifade yanlıştır.
           
        }

    }
}
