using System.Collections;
using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace HWPascalTriangle
{
    [TestClass]
    public class PascalTriangleTest
    {
        [TestMethod]
        public void One_Layer()
        {
            var actual = PascalTriangle.CalcualteLayer(1);
            CollectionAssert.AreEqual(new List<int> { 1 }, actual);
        }

        [TestMethod]
        public void Two_Layer()
        {
            var actual = PascalTriangle.CalcualteLayer(2);
            CollectionAssert.AreEqual(new List<int> { 1, 1, 1 }, actual);
        }

        [TestMethod]
        public void Three_Layer()
        {
            var actual = PascalTriangle.CalcualteLayer(3);
            CollectionAssert.AreEqual(new List<int> { 1, 1, 1, 1, 2, 1 }, actual);
        }

        [TestMethod]
        public void Four_Layer()
        {
            var actual = PascalTriangle.CalcualteLayer(4);
            CollectionAssert.AreEqual(new List<int> { 1, 1, 1, 1, 2, 1, 1, 3, 3, 1 }, actual);
        }

        [TestMethod]
        public void Five_Layer()
        {
            var actual = PascalTriangle.CalcualteLayer(5);
            CollectionAssert.AreEqual(new List<int> { 1, 1, 1, 1, 2, 1, 1, 3, 3, 1, 1, 4, 6, 4, 1 }, actual);
        }

        [TestMethod]
        public void Six_Layer()
        {
            var actual = PascalTriangle.CalcualteLayer(6);
            CollectionAssert.AreEqual(new List<int> { 1, 1, 1, 1, 2, 1, 1, 3, 3, 1, 1, 4, 6, 4, 1, 1, 5, 10, 10, 5, 1 }, actual);
        }
    }
}