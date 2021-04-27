using System;
using System.Collections.Generic;
using System.Text;

namespace Lesson_13
{
    public class Node
    {
        public int Value { get; set; }
        public Node Next { get; set; }
        public Node(int value)
        {
            Value = value;
            Next = null;
        }
    }
}
