using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace HWAnagramDetection
{
    [TestClass]
    public class AnagramDetectionTest
    {
        [TestMethod]
        public void AnagramDetectionTest_toffee()
        {
            var actual = AnagramDetection.IsAnagram("foefet", "toffee");
            Assert.AreEqual(true, actual);
        }

        [TestMethod]
        public void AnagramDetectionTest_DeathCubeK()
        {
            var actual = AnagramDetection.IsAnagram("Buckethead", "DeathCubeK");
            Assert.AreEqual(true, actual);
        }

        [TestMethod]
        public void AnagramDetectionTest_Woot()
        {
            var actual = AnagramDetection.IsAnagram("Twoo", "Woot");
            Assert.AreEqual(true, actual);
        }

        [TestMethod]
        public void AnagramDetectionTest_pale()
        {
            var actual = AnagramDetection.IsAnagram("apple", "pale");
            Assert.AreEqual(false, actual);
        }
    }
}