using System;
using System.Collections.Generic;

namespace Lesson_13
{
    class Program
    {
        static void Main(string[] args)
        {
            var list = new LinkedList<int>();

            var listEpty = new MyList();

            var listOne = new MyList(5);

            var listNew = new MyList(new int[] { 2, 4, 6 });

            //var list = new LinkedList<int>();

            //var listArray = new ArrayList();

            var myList = new MyList(5);

            listNew.Print();
            listNew.Reverse();
            listNew.Print();

            listNew.AddFirst(8);
            listNew.Print();

            listNew.AddAtIndex(9,1);
            listNew.Print();
            Console.WriteLine($"{listNew.GetMaxValue()}");
            Console.WriteLine($"{listNew.GetMinValue()}");
            Console.WriteLine("Hello World!");
        }
    }
}
