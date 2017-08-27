using System.Linq;

namespace Counting_Duplicates
{
    public class CountDuplicates
    {
        public static int DuplicateCount(string str)
        {
            if (string.IsNullOrEmpty(str))
            {
                return 0;
            }
            str = str.ToUpper();
            
            var duplicateCount = str.GroupBy(i => i).Where(g => g.Count() > 1).Count();

            return duplicateCount;
        }
    }
}
