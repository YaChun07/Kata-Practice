using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace HWMaximumLengthDiff
{
    [TestClass]
    public class MaximumLengthDiffTest
    {
        private MaxDiffLength _maxDiffLength;

        [TestInitialize]
        public void PreTest()
        {
            _maxDiffLength = new MaxDiffLength();
        }

        [TestMethod]
        public void Max_Diff_Should_Be_13()
        {
            string[] s1 = { "hoqq", "bbllkw", "oox", "ejjuyyy", "plmiis", "xxxzgpsssa", "xxwwkktt", "znnnnfqknaz", "qqquuhii", "dvvvwz" };
            string[] s2 = { "cccooommaaqqoxii", "gggqaffhhh", "tttoowwwmmww" };
            Assert.AreEqual(13, _maxDiffLength.Mxdiflg(s1, s2));
        }

        [TestMethod]
        public void String_With_Empty_Should_Be_MinusOne()
        {
            string[] s1 = { };
            string[] s2 = { "cccooommaaqqoxii", "gggqaffhhh", "tttoowwwmmww" };
            Assert.AreEqual(-1, _maxDiffLength.Mxdiflg(s1, s2));
        }

        [TestMethod]
        public void String_With_Digits_Should_Be_MinusOne()
        {
            string[] s1 = { "1" };
            string[] s2 = { "12345", "1", "123456789" };
            Assert.AreEqual(8, _maxDiffLength.Mxdiflg(s1, s2));
        }

        [TestMethod]
        public void Max_Diff_Should_Be_0()
        {
            string[] s1 = { "12345" };
            string[] s2 = { "12345", "12345", "12345" };
            Assert.AreEqual(0, _maxDiffLength.Mxdiflg(s1, s2));
        }
    }
}