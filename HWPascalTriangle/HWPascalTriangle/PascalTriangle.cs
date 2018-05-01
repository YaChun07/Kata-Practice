using System.Collections.Generic;

namespace HWPascalTriangle
{
    public static class PascalTriangle
    {
        public static List<int> CalcualteLayer(int totalLayer)
        {
            var ints = new List<int>();

            for (var i = 1; i <= totalLayer; i++)
            {
                ints.AddRange(PascalsTriangle(i));
            }
            return ints;
        }

        private static List<int> PascalsTriangle(int totalLayer)
        {
            if (totalLayer == 1)
            {
                return new List<int> { 1 };
            }
            else if (totalLayer == 2)
            {
                return new List<int> { 1, 1 };
            }
            else
            {
                var list = new List<int> { 1 };
                var ints = PascalsTriangle(totalLayer - 1);
                for (var i = 0; i < ints.Count - 1; i++)
                {
                    list.Add(ints[i] + ints[i + 1]);
                }
                list.Add(1);
                return list;
            }
        }
    }
}