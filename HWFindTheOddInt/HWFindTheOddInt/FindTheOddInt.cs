using System.Linq;

namespace HWFindTheOddInt
{
    public class FindTheOddInt
    {
        public static int find_it(int[] ints)
        {
            return ints.GroupBy(x => x).First(x => x.Count() % 2 != 0).Key;
        }
    }
}