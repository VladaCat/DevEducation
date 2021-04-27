using System;
using System.Collections.Generic;
using System.Text;
using HW_11.Interfaces;

namespace HW_11.Class
{
    public class Teacher : ITeacher
    {
        IMarkService _ms;


        public Teacher(IMarkService ms)
        {
            _ms = ms;
        }


        public int[] GetAllMarks(IPerson person)
        {
            if (person == null)
            {
                return new int[] { };
            }

            else
            {
                return _ms.GetAllMarks(person);
            }
        }

        public double GetAverage(IPerson person)
        {
            if (person == null)
            {
                return 0;
            }
            else
            {
                return _ms.GetAverage(person);
            }
        }

        public int GetLastMark(IPerson person, bool isLast)
        {
            if (person == null)
            {
                return 0;
            }
            else
            {
                return _ms.GetLastMark(person, isLast);
            }
        }
    }
}
