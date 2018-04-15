using System.Linq;

namespace HWAnagramDetection
{
    internal class AnagramDetection
    {
        public static bool IsAnagram(string test, string original)
        {
            var sortedTestString = string.Concat(test.ToLower().OrderBy(x => x));
            var sortedOriginalString = string.Concat(original.ToLower().OrderBy(x => x));

            return sortedOriginalString.Equals(sortedTestString);
        }
    }
}