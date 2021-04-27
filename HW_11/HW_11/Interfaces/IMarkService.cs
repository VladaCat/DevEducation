using System;
using System.Collections.Generic;
using System.Text;

namespace HW_11.Interfaces
{
    public interface IMarkService
    {
        int[] GetAllMarks(IPerson person);
        public string CheckMark(IPerson person);

        public double GetAverage(IPerson person);

        public int GetLastMark(IPerson person, bool isLast);
    }
}
