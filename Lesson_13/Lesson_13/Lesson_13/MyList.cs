using System;
using System.Collections.Generic;
using System.Text;

namespace Lesson_13
{
    public class MyList
    {
        public int Lenght { get; set; }
        private Node _root;
        private Node _tail;

        public MyList()
        {
            Lenght = 0;
            _root = null;
            _tail = null;
        }

        public MyList(int value)
        {

            Lenght = 1;
            _root = new Node(value);
            _tail = _root;
        }

        public MyList(int[] values)
        {
            Lenght = values.Length;
            if (values.Length != 0)
            {
                _root = new Node(values[0]);
                _tail = _root;
                for (int i = 1; i < values.Length; i++)
                {
                    _tail.Next = new Node(values[i]);
                    _tail = _tail.Next;
                }
            }
            else
            {
                _root = null;
                _tail = null;
            }
        }

        public void Add(int value)
        {
            Lenght++;
            _tail.Next = new Node(value);
            _tail = _tail.Next;
        }

        public void RemoveFirst()
        {
            _root = _root.Next;
            Lenght--;
        }

        public void RemoveItemByIndex(int index)
        {
            Node current = _root;
            if (index == 0) 
            {
                RemoveFirst();
                return;
            }
            for (int i = 1; i < index; i++)
            {
                current = current.Next;
            }
            current.Next = current.Next.Next;
            Lenght--;
        }

        public override bool Equals(object obj)
        {
            MyList list = (MyList)obj;
            if (this.Lenght != list.Lenght)
            {
                return false;
            }

            Node currentThis = _root;
            Node currentList = list._root;

            for (int i = 0; i < list.Lenght; i++)
            {
                if (currentThis.Value != currentList.Value)
                {
                    return false;
                }
                currentThis = currentThis.Next;
                currentList = currentList.Next;
            }
            //do
            //{
            //    if (currentThis.Value != currentList.Value)
            //    {
            //        return false;
            //    }
            //    currentThis = currentThis.Next;
            //    currentList = currentList.Next;
            //}
            //while (!(currentThis.Next is null));
            return true;
        }

        public void Reverse() 
        {
            Node tmp = _root.Next;
            _root.Next = null;
            for (int i = 0; i< Lenght-1; i++)
            { 
            Node current = tmp;
            tmp = tmp.Next;
            current.Next = _root;
            _root = current;
            }

        }

        public void Print() 
        {
            Node cuurNode = _root;
            for (int i =0; i<Lenght;i++) 
            {
                Console.Write($"{cuurNode.Value}\t");
                cuurNode = cuurNode.Next;
            }
            Console.WriteLine();
        }
        public void AddFirst(int value)
        {
            Lenght++;
            Node curr = new Node(value);
            curr.Next = _root;
            _root = curr;
        }

        public void AddAtIndex(int value, int index)
        {
            Node curr = _root;
            if (index == 0)
            {
                AddFirst(value);
                return;
            }
            for (int i = 1; i < index; i++)
            {
                curr = curr.Next;
            }
            Node tmp = new Node(value);
            tmp.Next = curr.Next;
            curr.Next = tmp;
            Lenght++;
        }

        public int GetMaxValue() 
        {
            int maxvalue = _root.Value;
            Node curr = _root.Next;
            for (int i = 0; i < Lenght-1;i++) 
            {
                if (maxvalue<curr.Value) 
                {
                    maxvalue = curr.Value;
                }
                curr = curr.Next;
            }
            return maxvalue;
        }

        public int GetMinValue()
        {
            int minvalue = _root.Value;
            Node curr = _root.Next;
            for (int i = 0; i < Lenght - 1; i++)
            {
                if (minvalue > curr.Value)
                {
                    minvalue = curr.Value;
                }
                curr = curr.Next;
            }
            return minvalue;
        }
    }
}
