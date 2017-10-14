using Microsoft.VisualStudio.TestTools.UnitTesting;
using Next_bigger_number_with_the_same_digits;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Next_bigger_number_with_the_same_digits.Tests
{
    [TestClass()]
    public class nextBiggerNumTests
    {
        [TestMethod()]
        public void two_digit_no_repeat()
        {
            Assert.AreEqual(21, nextBiggerNum.NextBiggerNumber(12));
        }
        [TestMethod()]
        public void three_digit_no_repeat()
        {
            Assert.AreEqual(531, nextBiggerNum.NextBiggerNumber(513));
        }
        [TestMethod()]
        public void three_digit_with_first_and_second_repeat()
        {
            Assert.AreEqual(441, nextBiggerNum.NextBiggerNumber(414));
        }
        [TestMethod()]
        public void three_digit_with_first_and_third_repeat()
        {
            Assert.AreEqual(414, nextBiggerNum.NextBiggerNumber(144));
        }
        [TestMethod()]
        public void four_digit_no_repeat()
        {
            Assert.AreEqual(2071, nextBiggerNum.NextBiggerNumber(2017));
        }
        [TestMethod()]
        public void four_digit_no_repeat_case2()
        {
            Assert.AreEqual(2716, nextBiggerNum.NextBiggerNumber(2671));
        }
        [TestMethod()]
        public void four_digit_with_no_repeat_case3()
        {
            Assert.AreEqual(2113, nextBiggerNum.NextBiggerNumber(1321));
        }
        [TestMethod()]
        public void four_digit_with_two_repeat()
        {
            Assert.AreEqual(2707, nextBiggerNum.NextBiggerNumber(2077));
        }
    }
}