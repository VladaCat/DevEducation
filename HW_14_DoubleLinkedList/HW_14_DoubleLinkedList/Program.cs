using System;

namespace HW_14_DoubleLinkedList
{
    class Program
    {
        static void Main(string[] args)
        {
            DoubleLinkedList<int> mylist= new DoubleLinkedList<int>();
            mylist.AddFirst(5);
            mylist.AddFirst(8);
            mylist.AddLast(9);
            mylist.AddFirst(4);
            mylist.AddFirst(5);
            mylist.AddLast(5);
            Console.WriteLine(mylist.Contains(8));
            mylist.Remove(9);
            mylist.Print();
            mylist.Clear(5);
            foreach (int el in mylist) 
            {
                Console.WriteLine($"{el+1}");
            }
        }
    }
}
