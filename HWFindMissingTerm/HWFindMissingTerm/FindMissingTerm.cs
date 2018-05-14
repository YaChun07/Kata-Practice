using System.Collections.Generic;
using System.Linq;

namespace HWFindMissingTerm
{
    internal class FindMissingTerm
    {
        public static int FindMissing(List<int> ints)
        {
            var diff = (ints[ints.Count - 1] - ints[0]) / ints.Count;
            return ints.Select(t => t + diff).FirstOrDefault(next => !ints.Contains(next));
        }
    }
}