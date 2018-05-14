using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace HWMultiples
{
    [TestClass]
    public class MultiplesTest
    {
        [TestMethod]
        public void Find_Factor_Below_10()
        {
            var actual = Multiples.Calculate(10);
            Assert.AreEqual(23,actual);
        }

        [TestMethod]
        public void Find_Factor_Below_15()
        {
            var actual = Multiples.Calculate(15);
            Assert.AreEqual(45,actual);
        }
        [TestMethod]
        public void Find_Factor_Below_100()
        {
            var actual = Multiples.Calculate(100);
            Assert.AreEqual(2318,actual);
        }
    }
}
