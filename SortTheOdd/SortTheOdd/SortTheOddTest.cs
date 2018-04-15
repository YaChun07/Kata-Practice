using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace HWSortTheOdd
{
    [TestClass]
    public class SortTheOddTest
    {
        [TestMethod]
        public void sortArray_with_6int()
        {
            var actual = SortTheOdd.SortArray(new int[] { 5, 3, 2, 8, 1, 4 });
            var expect = new int[] { 1, 3, 2, 8, 5, 4 };
            CollectionAssert.AreEqual(expect, actual);
        }

        [TestMethod]
        public void sortArray_with_5int()
        {
            var actual = SortTheOdd.SortArray(new int[] { 5, 3, 1, 8, 0 });
            var expect = new int[] { 1, 3, 5, 8, 0 };
            CollectionAssert.AreEqual(expect, actual);
        }

        [TestMethod]
        public void sortArray_with_2int()
        {
            var actual = SortTheOdd.SortArray(new int[] { 10, 3 });
            var expect = new int[] { 10, 3 };
            CollectionAssert.AreEqual(expect, actual);
        }

        [TestMethod]
        public void sortArray_with_2zero()
        {
            var actual = SortTheOdd.SortArray(new int[] { 15, 3, 5, 0, 0, 6 });
            var expect = new int[] { 3, 5, 15, 0, 0, 6 };
            CollectionAssert.AreEqual(expect, actual);
        }

        [TestMethod]
        public void sortArray_with_AllEven()
        {
            var actual = SortTheOdd.SortArray(new int[] { 0, 2, 4, 6 });
            var expect = new int[] { 0, 2, 4, 6 };
            CollectionAssert.AreEqual(expect, actual);
        }

        [TestMethod]
        public void sortArray_with_null()
        {
            var actual = SortTheOdd.SortArray(new int[] { });
            var expect = new int[] { };
            CollectionAssert.AreEqual(expect, actual);
        }
    }
}