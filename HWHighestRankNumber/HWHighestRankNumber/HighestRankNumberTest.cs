using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace HWHighestRankNumber
{
    [TestClass]
    public class HighestRankNumberTest
    {
        [TestMethod]
        public void Rank_Max_count_with_smallest_num()
        {
            Assert.AreEqual(3, HighestRankNumber.HighestRank(new[] { 12, 10, 8, 8, 3, 3, 3, 3, 2, 4, 10, 12, 10 }));
        }

        [TestMethod]
        public void Rank_same_max_count()
        {
            Assert.AreEqual(12, HighestRankNumber.HighestRank(new[] { 12, 10, 8, 12, 7, 6, 4, 10, 12, 10 }));
        }

        [TestMethod]
        public void Rank_same_max_count_by_order()
        {
            Assert.AreEqual(12, HighestRankNumber.HighestRank(new[] { 12, 10, 8, 12, 7, 6, 4, 10, 12 }));
        }
    }
}