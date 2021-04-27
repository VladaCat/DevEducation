using System;
using System.Collections.Generic;
using System.Text;
using System.ComponentModel;

namespace HW_11.Interfaces
{
    public interface ITeacher:IPerson
    {
        public int[] GetAllMarks(IPerson person);

        public double GetAverage(IPerson person);

        public int GetLastMark(IPerson person, bool isLast);
    }
}
