using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace HW_14_DoubleLinkedList
{
    public class DoubleLinkedList<T> : IDoubleLinkedList<T>, IEnumerable<T>
    {
        Node<T> head=null;
        Node<T> tail=null;
        int count = 0;

        public DoubleLinkedList()
        {
            //head = new Node<T>();
        }


        public int Count => count;

        public bool isEmpty => count==0;

        public void Print() 
        {
            Node<T> node = head;
            for (int i = 0; i < count; i++)
            {
                Console.Write($"{node.Data} ");
                node = node.Next;
            }
            Console.WriteLine();
        }
        public void AddFirst(T data)
        {
            Node<T> node = new Node<T>(data);
            if (count == 0) { tail = node;head = node; }
            node.Next = head;
            head.Previous = node;
            head = node;
            count++;
            Print();
        }

        public void AddLast(T data)
        {
            Node<T> node = new Node<T>(data);
            if (count == 0) { tail = node; head = node; }
            node.Previous = tail;
            tail.Next = node;
            tail = node;
            count++;
            Print();
        }

        public IEnumerable<T> BackEnumerator()
        {
            var current = tail;
            while (current != null)
            {
                yield return current.Data;
                current = current.Previous;
            }
        }

        public void Clear(T data)
        {
            while (Contains(data)) 
            {
                Remove(data);
            }
            Print();
        }

        public bool Contains(T data)
        {

            Node<T> node = head;
            for (int i =0; i<count-1;i++) 
            {
                if (node.Data.Equals(data)) 
                {
                    return true;
                }
                node = node.Next;
            }
            return node.Data.Equals(data);
        }

        public IEnumerator<T> GetEnumerator()
        {
            var current = head;
            while (current != null)
            {
                yield return current.Data;
                current = current.Next;
            }
        }

        public bool Remove(T data)
        {
            if (head.Data.Equals(data)) 
            {
                head = head.Next;
                head.Previous = null;
                count--;
                return true;
            }
            Node<T> node = head.Next;
                for (int i = 0; i < count - 2; i++)
                {
                    if (node.Data.Equals(data))
                    {
                        node.Previous.Next = node.Next;
                        node.Next.Previous = node.Previous;
                        count--;
                        return true;
                    }
                    node = node.Next;
                }    
            if (tail.Data.Equals(data))
            {
                tail = tail.Previous;
                tail.Next = null;
                count--;
                return true;
            }
            return false;
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }
    }
}
