using System;
using System.Linq;

namespace HWMaximumLengthDiff
{
    public class MaxDiffLength
    {
        public int Mxdiflg(string[] s1, string[] s2)
        {
            if (s1.Length == 0 || s2.Length == 0)
            {
                return -1;
            }

            var s1LengthList = s1.Select(s => s.Length).ToList();
            var s2LengthList = s2.Select(s => s.Length).ToList();

            var maxValue1 = s1LengthList.Max() - s2LengthList.Min();
            var maxValue2 = s2LengthList.Max() - s1LengthList.Min();
            
            return Math.Max(maxValue1 , maxValue2);
        }
    }
}