using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace HWCountingChangeCombinations
{
    [TestClass]
    public class CountingChangeCombinationsTest
    {
        [TestMethod]
        public void CountingChangeCombinationsTest_1()
        {
            var actual = CountingChangeCombinations.CountCombinations(4, new[] { 1, 2 });
            Assert.AreEqual(3, actual);
        }

        [TestMethod]
        public void CountingChangeCombinationsTest_2()
        {
            var actual = CountingChangeCombinations.CountCombinations(10, new[] { 5, 2, 3 });
            Assert.AreEqual(4, actual);
        }

        [TestMethod]
        public void CountingChangeCombinationsTest_3()
        {
            var actual = CountingChangeCombinations.CountCombinations(11, new[] { 5, 7 });
            Assert.AreEqual(0, actual);
        }

    }
}