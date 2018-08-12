using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace HWRomanConvert
{
    [TestClass]
    public class RomanConvertTest
    {
        private RomanConvert _romanConvert;

        [TestInitialize]
        public void PreTest()
        {
            _romanConvert = new RomanConvert();
        }

        [TestMethod]
        public void Test_With_One()
        {
            Assert.AreEqual("I", _romanConvert.Solution(1));
        }

        [TestMethod]
        public void Test_With_Two()
        {
            Assert.AreEqual("II", _romanConvert.Solution(2));
        }

        [TestMethod]
        public void Test_With_Four()
        {
            Assert.AreEqual("IV", _romanConvert.Solution(4));
        }

        [TestMethod]
        public void Test_With_FiveHundred()
        {
            Assert.AreEqual("D", _romanConvert.Solution(500));
        }

        [TestMethod]
        public void Test_With_OneThousand()
        {
            Assert.AreEqual("M", _romanConvert.Solution(1000));
        }

        [TestMethod]
        public void Test_With_OneThousand_And_OneFive_And_OneFour()
        {
            Assert.AreEqual("MCMLIV", _romanConvert.Solution(1954));
        }

        [TestMethod]
        public void Test_With_OneThousand_And_DoubleNine()
        {
            Assert.AreEqual("MCMXC", _romanConvert.Solution(1990));
        }

        [TestMethod]
        public void Test_With_DoubleZero()
        {
            Assert.AreEqual("MMVIII", _romanConvert.Solution(2008));
        }

        [TestMethod]
        public void Test_With_TwoThousand_And_OneFour()
        {
            Assert.AreEqual("MMXIV", _romanConvert.Solution(2014));
        }
    }
}