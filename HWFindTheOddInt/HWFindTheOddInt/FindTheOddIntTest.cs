using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace HWFindTheOddInt
{
    [TestClass]
    public class FindTheOddIntTest
    {
        [TestMethod]
        public void MixArray_ShouldBe_5()
        {
            Assert.AreEqual(5, FindTheOddInt.find_it(new[] { 20, 1, -1, 2, -2, 3, 3, 5, 5, 1, 2, 4, 20, 4, -1, -2, 5 }));
        }

        [TestMethod]
        public void MixArray_ShouldBe_Minus1()
        {
            Assert.AreEqual(-1, FindTheOddInt.find_it(new[] { -1, 1, -1, -1, -1, -1, 1 }));
        }

        [TestMethod]
        public void PureArray_ShouldBe_1()
        {
            Assert.AreEqual(1, FindTheOddInt.find_it(new[] { 1, 1, 1, 1, 1, 1, 1 }));
        }

        [TestMethod]
        public void OneNumArray_ShouldBe_0()
        {
            Assert.AreEqual(0, FindTheOddInt.find_it(new[] { 0 }));
        }
    }
}