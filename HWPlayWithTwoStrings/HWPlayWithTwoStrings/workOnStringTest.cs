using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace HWPlayWithTwoStrings
{
    [TestClass]
    public class WorkOnStringTest
    {
        [TestMethod]
        public void smile67KataTest_withoutRandom1()
        {
            Assert.AreEqual("abCCde", new WorkOnStrings().CombineString("abc", "cde"));
        }

        [TestMethod]
        public void smile67KataTest_withoutRandom2()
        {
            Assert.AreEqual("ABABbababa", new WorkOnStrings().CombineString("abab", "bababa"));
        }

       [TestMethod]
        public void smile67KataTest_withoutRandom3()
        {
            Assert.AreEqual("abcDeFGtrzWDEFGgGFhjkWqE", new WorkOnStrings().CombineString("abcdeFgtrzw", "defgGgfhjkwqe"));
        }
       
        [TestMethod]
        public void smile67KataTest_withoutRandom4()
        {
            Assert.AreEqual("abcDEfgDEFGg", new WorkOnStrings().CombineString("abcdeFg", "defgG"));
        }
    }
}
