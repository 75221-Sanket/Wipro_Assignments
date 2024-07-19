
using System;

namespace LinkedList
{
    public class node
    {
        public int Data { get; set; }
        public node Next { get; set; }

        public node(int d)
        {
            Data = d;
            Next = null;

        }
    }
    public class MyLinkedList
    {
        public node Head { get; set; }
        public MyLinkedList()
        {
            Head = null;
        }
        public void Addnode(int d)
        {
            node obj = new node(d);
            if (Head == null)
            {
                Head = obj;

            }
            else
            {
                node temp = Head;
                while (temp.Next != null)
                {
                    temp = temp.Next;
                }

                temp.Next = obj;
            }
        }
        public void ShowList()
        {
            node temp = Head;
            while (temp != null)
            {
                Console.WriteLine("{0} -->", temp.Data);
                temp = temp.Next;
            }
            Console.WriteLine("null");

        }
        public void Removenode(int d)
        {
            node temp = Head;
            node previous = null;
            if (temp != null && temp.Data == d)
            {
                Head = temp.Next;
                Console.WriteLine("{0} found and removed", d);
                return;
            }
            while (temp != null && temp.Data! == d)
            {
                previous = temp;
                temp = temp.Next;
            }

            if (temp == null)
            {
                Console.WriteLine("{0} not found in this list", d);
                return;
            }
            //previous.Next = temp.Next;

            Console.WriteLine("{0}  found and removed", d);
        }
    }
    public class program
    {
        public static void Main(string[] args)
        {
            MyLinkedList lstObj = new MyLinkedList();

            lstObj.Addnode(10);

            lstObj.Addnode(20);

            lstObj.Addnode(30);

            lstObj.Addnode(40);

            lstObj.Addnode(50);

            Console.WriteLine("Initial list");

            lstObj.ShowList();

            lstObj.Removenode(20);
            Console.WriteLine("List after removing 20 ");
            lstObj.ShowList();

            lstObj.Removenode(50);
            Console.WriteLine("List after removing 50 ");
            lstObj.ShowList();

            lstObj.Removenode(60);
            Console.WriteLine("Attempting to removing 60 ");
            lstObj.ShowList();

            Console.ReadLine();

        }
    }
}
