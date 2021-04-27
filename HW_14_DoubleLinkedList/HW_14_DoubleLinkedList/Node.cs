using System;
using System.Collections.Generic;
using System.Text;

namespace HW_14_DoubleLinkedList
{
    public class Node<T>
    {
        public bool isnull=false;
        public Node(T data) 
        {
            Data = data;
        }
        public Node()
        {
            isnull = true;
        }
        public Node<T> Next { get; set; }
        public Node<T> Previous { get; set; }
        public T Data { get; set; }
    }
}
