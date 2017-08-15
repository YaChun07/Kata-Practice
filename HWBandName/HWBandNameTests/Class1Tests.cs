using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using HWBandName;
using Microsoft.VisualStudio.TestTools.UnitTesting;
namespace HWBandName.Tests
{
    [TestClass()]
    public class Class1Tests
    {
        [TestMethod()]
        public void NoSameLetter()
        {
            Assert.AreEqual("The Knife", Class1.BandNameGenerator("knife"));
            Assert.AreEqual("The Bed", Class1.BandNameGenerator("bed"));
            Assert.AreEqual("The Good", Class1.BandNameGenerator("Good"));
        }
        [TestMethod()]
        public void HasSameLetter()
        {
            Assert.AreEqual("Tartart", Class1.BandNameGenerator("Tart"));
            Assert.AreEqual("Sandlesandles", Class1.BandNameGenerator("sandles"));
        }
        [TestMethod()]
        public void NullLetter()
        {
            Assert.AreEqual("Null", Class1.BandNameGenerator(" "));
            Assert.AreEqual("Null", Class1.BandNameGenerator(""));
        }
    }

}
