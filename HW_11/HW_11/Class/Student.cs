using HW_11.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace HW_11.Class
{
    public class Student : IStudent
    {
        public int[] marks;

        IMarkService _ms;

        public Student(IMarkService ms, int[] marks)
        {
            this.marks = marks;
            _ms = ms;
        }
        public Student(int[] marks)
        {
            this.marks = marks;
            _ms = new MarkService();
        }

        public string CheckMark() 
        {
            return _ms.CheckMark((IPerson)this);
        }
    }
}
