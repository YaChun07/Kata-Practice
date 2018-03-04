using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace HWNextSmallerNumberWithTheSameDigits
{
    [TestClass]
    public class NextSmallerNumberTest
    {
        [TestMethod]
        public void TwoDigits()
        {
            Assert.AreEqual(12, NextSmallerNumber.NextSmaller(21));
        }

        [TestMethod]
        public void ThreeDigits()
        {
            Assert.AreEqual(790, NextSmallerNumber.NextSmaller(907));
        }

        [TestMethod]
        public void ThreeDigits_with_TwoDuplicate()
        {
            Assert.AreEqual(414, NextSmallerNumber.NextSmaller(441));
        }

        [TestMethod]
        public void ThreeDigits_with_DecSort()
        {
            Assert.AreEqual(513, NextSmallerNumber.NextSmaller(531));
        }

        [TestMethod]
        public void FourDigits_and_nosmallerNum()
        {
            Assert.AreEqual(-1, NextSmallerNumber.NextSmaller(1027));
        }

        [TestMethod]
        public void NineDigits()
        {
            Assert.AreEqual(123456789, NextSmallerNumber.NextSmaller(123456798));
        }
    }
}