using System.Linq;

namespace HWSortTheOdd
{
    internal class SortTheOdd
    {
        public static int[] SortArray(int[] intsArray)
        {
            if (intsArray == null)
            {
                return new int[] { };
            }

            var oddsArray = intsArray.Where(x => x % 2 == 1).OrderBy(x => x).ToArray();

            var count = 0;

            for (var i = 0; i < intsArray.Length; i++)
            {
                if (intsArray[i] % 2 == 1)
                {
                    intsArray[i] = oddsArray[count];
                    count++;
                }
            }

            return intsArray;
        }
    }
}