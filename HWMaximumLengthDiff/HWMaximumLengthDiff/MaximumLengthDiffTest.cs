using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace HWMaximumLengthDiff
{
    [TestClass]
    public class MaximumLengthDiffTest
    {
        [TestMethod]
        public void Max_Diff_Should_Be_13()
        {
            var maxDiffLength = new MaxDiffLength();
            string[] s1 = { "hoqq", "bbllkw", "oox", "ejjuyyy", "plmiis", "xxxzgpsssa", "xxwwkktt", "znnnnfqknaz", "qqquuhii", "dvvvwz" };
            string[] s2 = { "cccooommaaqqoxii", "gggqaffhhh", "tttoowwwmmww" };
            Assert.AreEqual(13, maxDiffLength.Mxdiflg(s1, s2));
        }

        [TestMethod]
        public void String_With_Empty_Should_Be_MinusOne()
        {
            var maxDiffLength = new MaxDiffLength();
            string[] s1 = {};
            string[] s2 = { "cccooommaaqqoxii", "gggqaffhhh", "tttoowwwmmww" };
            Assert.AreEqual(-1, maxDiffLength.Mxdiflg(s1, s2));
        }

        [TestMethod]
        public void String_With_Digits_Should_Be_MinusOne()
        {
            var maxDiffLength = new MaxDiffLength();
            string[] s1 = { "1"};
            string[] s2 = { "12345", "1", "123456789" };
            Assert.AreEqual(8, maxDiffLength.Mxdiflg(s1, s2));
        }

        [TestMethod]
        public void Max_Diff_Should_Be_0()
        {
            var maxDiffLength = new MaxDiffLength();
            string[] s1 = { "12345"};
            string[] s2 = { "12345", "12345", "12345" };
            Assert.AreEqual(0, maxDiffLength.Mxdiflg(s1, s2));
        }
    }
}
