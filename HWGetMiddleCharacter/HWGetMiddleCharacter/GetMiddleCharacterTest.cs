using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace HWGetMiddleCharacter
{
    [TestClass]
    public class GetMiddleCharacterTest
    {
        [TestMethod]
        public void Even_Length()
        {
            Assert.AreEqual("es", GetMiddleCharacter.GetMiddle("test"));
        }

        [TestMethod]
        public void Odd_Length()
        {
            Assert.AreEqual("t", GetMiddleCharacter.GetMiddle("testing"));
        }

        [TestMethod]
        public void Even_Length_With_Duplicate_Letter()
        {
            Assert.AreEqual("dd", GetMiddleCharacter.GetMiddle("middle"));
        }

        [TestMethod]
        public void Odd_Length_With_One_Letter()
        {
            Assert.AreEqual("A", GetMiddleCharacter.GetMiddle("A"));
        }
       
    }
}
