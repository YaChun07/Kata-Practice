using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace PersistentBugger
{
    [TestClass]
    public class PersistentBuggerTest
    {
        [TestMethod]
        public void Two_Digits_Return_3Times()
        {
            Assert.AreEqual(3, PersistentBugger.Persistence(39));
        }

        [TestMethod]
        public void One_Digits_Return_0Times()
        {
            Assert.AreEqual(0, PersistentBugger.Persistence(4));
        }

        [TestMethod]
        public void Two_Digits_Return_2Times()
        {
            Assert.AreEqual(2, PersistentBugger.Persistence(25));
        }

        [TestMethod]
        public void Three_Digits_Return_4Times()
        {
            Assert.AreEqual(4, PersistentBugger.Persistence(999));
        }

        [TestMethod]
        public void Four_Digits_Return_1Times()
        {
            Assert.AreEqual(1, PersistentBugger.Persistence(1111));
        }
    }
}