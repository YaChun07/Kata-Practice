using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace HWExesAndOhs
{
    [TestClass]
    public class ExesAndOhsTest
    {
        [TestMethod]
        public void Test_For_All_LowerCase_1x1o_ShouldBe_True()
        {
            Assert.AreEqual(true, ExesAndOhs.Xo("xo"));
        }

        [TestMethod]
        public void Test_For_OneUpperCase_2x2o_ShouldBe_True()
        {
            Assert.AreEqual(true, ExesAndOhs.Xo("xxOo"));
        }

        [TestMethod]
        public void Test_For_AllLowerCase_3x0o1other_ShouldBe_False()
        {
            Assert.AreEqual(false, ExesAndOhs.Xo("xxxm"));
        }

        [TestMethod]
        public void Test_For_OneUpperCase_0x2o_ShouldBe_False()
        {
            Assert.AreEqual(false, ExesAndOhs.Xo("Oo"));
        }

        [TestMethod]
        public void Test_For_AllLowerCase_0x3o1other_ShouldBe_False()
        {
            Assert.AreEqual(false, ExesAndOhs.Xo("ooom"));
        }
    }
}