using System.Collections;
using System.Collections.Generic;

namespace HWPascalTriangle
{
    public static class PascalTriangle
    {
        public static List<int> CalcualteLayer(int totalLayer)
        {
            var results = new List<int>();

            for (var i = 1; i <= totalLayer; i++)
            {
                results.AddRange(PascalsTriangle(i));
            }
            return results;
        }

        private static List<int> PascalsTriangle(int totalLayer)
        {
            switch (totalLayer)
            {
                case 1:
                    return new List<int> { 1 };
                case 2:
                    return new List<int> { 1, 1 };
                default:
                    {
                        var currentList = new List<int> { 1 };
                        var preLayerList = PascalsTriangle(totalLayer - 1);

                        for (var i = 0; i < preLayerList.Count - 1; i++)
                        {
                            currentList.Add(preLayerList[i] + preLayerList[i + 1]);
                        }
                        currentList.Add(1);

                        return currentList;
                    }
            }
        }
    }
}