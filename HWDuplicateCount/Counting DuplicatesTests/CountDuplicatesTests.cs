using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Counting_Duplicates.Tests
{
    [TestClass()]
    public class CountDuplicatesTests
    {
        [TestMethod()]
        public void answer_0_when_stringisnull()
        {
            Assert.AreEqual(0, CountDuplicates.DuplicateCount(""));
        }
        [TestMethod()]
        public void answer_2_when_two_duplicate()
        {
            Assert.AreEqual(2, CountDuplicates.DuplicateCount("aabbcde"));
        }
        [TestMethod()]
        public void answer_0_when_no_duplicate()
        {
            Assert.AreEqual(0, CountDuplicates.DuplicateCount("abcd"));
        }
        [TestMethod()]
        public void answer_2_when_two_duplicate_and_one_upper_case()
        {
            Assert.AreEqual(2, CountDuplicates.DuplicateCount("aabBcde"), "should ignore case");
        }

        [TestMethod()]
        public void answer_1_when_one_duplicate_and_one_upper_case_vacabulary()
        {
            Assert.AreEqual(1, CountDuplicates.DuplicateCount("Indivisibility"));
        }

        [TestMethod()]
        public void answer_2_when_two_duplicate_and_one_upper_case_vacabulary()
        {
            Assert.AreEqual(2, CountDuplicates.DuplicateCount("Indivisibilities"), "characters may not be adjacent");
        }
    }
}