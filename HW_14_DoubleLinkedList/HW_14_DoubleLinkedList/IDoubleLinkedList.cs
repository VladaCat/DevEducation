using System;
using System.Collections.Generic;
using System.Text;

namespace HW_14_DoubleLinkedList
{
    interface IDoubleLinkedList<T>
    {
        void AddLast(T data);
        void AddFirst(T data);
        bool Remove(T data);
        bool Contains(T data);
        void Clear(T data);
        int Count { get; }
        bool isEmpty { get; }
        IEnumerable<T> BackEnumerator();
    }
}
