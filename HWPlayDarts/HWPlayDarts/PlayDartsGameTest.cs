using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace HWPlayDarts
{
    [TestClass]
    public class PlayDartsGameTest
    {
        [TestMethod]
        public void OutSideTest()
        {
            var actual = PlayDartsGame.GetScore(-133.690, -147.380);
            Assert.AreEqual("X", actual);
        }

        [TestMethod]
        public void BullEye()
        {
            var actual = PlayDartsGame.GetScore(4.06, 0.71);
            Assert.AreEqual("DB", actual);
        }

        [TestMethod]
        public void Bull()
        {
            var actual = PlayDartsGame.GetScore(2.38, -6.06);
            Assert.AreEqual("SB", actual);
        }

        [TestMethod]
        public void SingleNumber_20()
        {
            var actual = PlayDartsGame.GetScore(-5.43, 117.95);
            Assert.AreEqual("20", actual);
        }

        [TestMethod]
        public void SingleNumber_7()
        {
            var actual = PlayDartsGame.GetScore(-73.905, -95.94);
            Assert.AreEqual("7", actual);
        }

        [TestMethod]
        public void tripleNumber_2()
        {
            var actual = PlayDartsGame.GetScore(55.53, -87.95);
            Assert.AreEqual("T2", actual);
        }

        [TestMethod]
        public void doubleNumber_9()
        {
            var actual = PlayDartsGame.GetScore(-145.19, 86.53);
            Assert.AreEqual("D9", actual);
        }
    }
}