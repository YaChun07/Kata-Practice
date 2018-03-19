using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace HWRunnersMeetings
{
    [TestClass]
    public class RunnersMeetingTest
    {
        [TestMethod]
        public void RunnersMeetingsTest_with_last_Winner()
        {
            Assert.AreEqual(3, RunnersMeetings.CountMeetPeople(new int[] { 1, 4, 2 }, new int[] { 27, 18, 24 }));
        }

        [TestMethod]
        public void RunnersMeetingsTest_with_second_Winner()
        {
            Assert.AreEqual(2, RunnersMeetings.CountMeetPeople(new int[] { 1, 4, 2 }, new int[] { 5, 6, 2 }));
        }

        [TestMethod]
        public void RunnersMeetingsTest_with_no_winner()
        {
            Assert.AreEqual(-1, RunnersMeetings.CountMeetPeople(new int[] { 1, 2, 3 }, new int[] { 1, 1, 1 }));
        }

        [TestMethod]
        public void RunnersMeetingsTest_with_two_player()
        {
            Assert.AreEqual(2, RunnersMeetings.CountMeetPeople(new int[] { 1, 1000 }, new int[] { 23, 22 }));
        }

        [TestMethod]
        public void RunnersMeetingsTest_with_twelve_player()
        {
            Assert.AreEqual(2, RunnersMeetings.CountMeetPeople(new int[] { -784, -42, -35, 33, -38, -21, -18, 27, -39, -36, -628, 16 }, new int[] { 18, 29, 17, 19, 13, 10, 21, 1, 16, 19, 5, 11 }));
        }
    }
}