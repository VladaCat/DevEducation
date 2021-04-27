using HW_11.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace HW_11.Class
{
    public class MarkService : IMarkService
    {
        public int[] GetAllMarks(IPerson person)
        {
            return ((Student)person).marks;
        }

        public string CheckMark(IPerson person)
        {
            return GetAverage(person) > 7 ? "Great job" : "Bad job";
        }

        public double GetAverage(IPerson person)
        {
            return GetAllMarks(person).Average();
        }

        public int GetLastMark(IPerson person, bool isLast)
        {
            int[] tmp = GetAllMarks(person);
            return isLast ? tmp.Last() : tmp[tmp.Length - 2];
        }
    }
}
