using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VYD20102015
{
    class LinkedList<T> where T : IComparable
    {
        Node<T> head;

        public void AddToEndRecursively(T val)
        {
            AddToEndRecursively(head, val);
        }
        public void AddToEndRecursively(Node<T> first, T val)
        {
            if (first == null)
                head = new Node<T>(val);
            else if (first.Next == null)
                first.Next = new Node<T>(val);
            else
                AddToEndRecursively(first.Next, val);

        }
        public void AnotherRecursiveToAddToEnd(T val)
        {
            head = AnotherRecursiveToAddToEnd(head, val);
        }
        public Node<T> AnotherRecursiveToAddToEnd(Node<T> first, T val)
        {
            if (first == null)
                return new Node<T>(val);
            else
                first.Next = AnotherRecursiveToAddToEnd(first.Next, val);
            return first;

        }

        public void AddToFront(T val) // Başa ekleme
        {
            Node<T> temp = new Node<T>(val);
            temp.Next = head;
            head = temp;
        }

        public void DeleteFromHead()  // Baştan eleman silme
        {
            if (head != null)
                head = head.Next;
        }
        public void DeleteFromEnd() // Sondan eleman silme
        {
            if (head == null || head.Next == null)
                head = null;
            //else
            //{
            //    Node<T> iterator = head;
            //    while (iterator.Next.Next != null)
            //        iterator = iterator.Next;
            //    iterator.Next = null;
            //}
            else
            {
                Node<T> iterator = head;
                Node<T> previous = head;
                while (iterator.Next != null)
                {
                    previous = iterator;
                    iterator = iterator.Next;
                }
                previous.Next = null;
            }

        }
        public void Delete(T val)
        {
            if (search(val))
            {
                while (head.Value.CompareTo(val) == 0)
                    head = head.Next;
                Node<T> iterator = head;
                Node<T> previous = head;
                while (iterator != null)
                {

                    if (iterator.Value.CompareTo(val) == 0)
                    {
                        previous.Next = iterator.Next;
                        iterator = iterator.Next;
                    }
                    else
                    {
                        previous = iterator;
                        iterator = iterator.Next;
                    }
                }
            }

        }

        public void AddSorted(T val)
        {
            if(head == null || head.Value.CompareTo(val)==1) //liste boş veya eklenecek elaman en küçükse başa ekleme
            {
                AddToFront(val);
            }
            else
            {

                Node<T> iterator = head;
                Node<T> previous = head;

                while(iterator!=null)
                {
                    if(iterator.Value.CompareTo(val)==1) //Araya ekleme
                    {
                        Node<T> temp = new Node<T>(val);
                        //previous.Next= new Node<T>(val);
                        //previous.Next.Next = new Node<T>(val);
                        previous.Next = temp;
                        temp.Next = iterator;
                        break;

                    }
                    previous = iterator;
                    iterator = iterator.Next;
                   
                }

                if (iterator == null) // sona ekleme durumu
                {
                    previous.Next = new Node<T>(val);
                }

            }
        }

        private int count()
        {
            int count = 0;
            Node<T> iterator = head;
            while(iterator!=null)
            {
                count = count + 1;
                iterator = iterator.Next;
            }
            return count;
        }

        public void Insert(T val,int index)
        {
            Node<T> temp = new Node<T>(val);
            int cnt = count();

            if (index>=0 && index<=cnt) // index geçerli aralıkta mı onun kontrolunu yapıyor.
            {
                
                if (index==0)  // liste boşsa başa ekleme
                {
                    AddToFront(val); 
                }

                else if(index==cnt) // sona ekleme
                {
                    AddToEnd(val);
                }
                else // index arada bir değerse 
                {

                    Node<T> iterator = head;
                    Node<T> previous = head;

                    for(int i=0;i < index;i++)
                    {
                        previous = iterator;
                        iterator = iterator.Next;
                    }

                    previous.Next = temp;
                    temp.Next = iterator;
                }
                
            }

            else
            {
                throw new Exception("Invalid index!!");
            }
           
        } 

        public void AddToEnd(T val) // Sona ekleme
        {
            Node<T> temp = new Node<T>(val);
            if (head == null)
                head = temp;
            else
            {
                Node<T> iterator = head;
                while (iterator.Next != null)
                    iterator = iterator.Next;
                iterator.Next = temp;
            }
        }

        public bool search(T searchVal) // Arama metodu
        {
            Node<T> iterator = head;
            while(iterator != null)
            {
                if(iterator.Value.CompareTo(searchVal)==0)
                {
                    return true;
                }
                iterator = iterator.Next;
                
            }
            return false;
        }

       

        public void Display() // elemanları görüntüleme metodu
        {
            Node<T> iterator = head;
            while (iterator != null)
            {
                Console.WriteLine(iterator.Value);
                iterator = iterator.Next;

            }
            Console.WriteLine();

        }

    }
}
