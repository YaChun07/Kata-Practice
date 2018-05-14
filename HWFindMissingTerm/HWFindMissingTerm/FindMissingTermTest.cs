using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;

namespace HWFindMissingTerm
{
    [TestClass]
    public class FindMissingTermTest
    {
      
        [TestMethod]
        public void List_With_Diff_2()
        {
            var actual = FindMissingTerm.FindMissing(new List<int> { 1, 3, 5, 9, 11 });
            Assert.AreEqual(7, actual);
        }

        [TestMethod]
        public void List_With_Diff_5()
        {
            var actual = FindMissingTerm.FindMissing(new List<int> { 0, 5, 10, 20, 25 });
            Assert.AreEqual(15, actual);
        }

        [TestMethod]
        public void List_With_diff_1()
        {
            var actual = FindMissingTerm.FindMissing(new List<int> { 0, 1, 2, 3, 4, 5, 6, 7, 8, 9, 11 });
            Assert.AreEqual(10, actual);
        }

        [TestMethod]
        public void List_With_diff_180()
        {
            var actual = FindMissingTerm.FindMissing(new List<int> { 1040, 1220, 1580 });
            Assert.AreEqual(1400, actual);
        }
    }
}