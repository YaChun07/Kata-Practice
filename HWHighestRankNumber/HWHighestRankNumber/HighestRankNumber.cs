using System.Linq;

namespace HWHighestRankNumber
{
    internal class HighestRankNumber
    {
        public static int HighestRank(int[] arr)
        {
            return arr.GroupBy(x => x).OrderBy(y => y.Count()).ThenBy(x => x.Key).ToList().Last().Key;
        }
    }
}