using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace HWDigitalCypher
{
    [TestClass]
    public class DigitalCypherTest
    {
        private DigitalCypher _digitalCypher;

        [TestInitialize]
        public void PretestSetting()
        {
            _digitalCypher = new DigitalCypher();
        }

        [TestMethod]
        public void Secretkey_1939_With_Length_5()
        {
            var actual = _digitalCypher.Encode("scout", 1939);
            var expected = new[] { 20, 12, 18, 30, 21 };

            CollectionAssert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void Secretkey_1939_With_Length_11()
        {
            var actual = _digitalCypher.Encode("masterpiece", 1939);
            var expected = new[] { 14, 10, 22, 29, 6, 27, 19, 18, 6, 12, 8 };

            CollectionAssert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void Secretkey_1939_With_Length_1()
        {
            var actual = _digitalCypher.Encode("a", 1939);
            var expected = new[] { 2 };

            CollectionAssert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void Secretkey_1991_With_Length_5()
        {
            var actual = _digitalCypher.Encode("happy", 1991);
            var expected = new[] { 9, 10, 25, 17, 26 };

            CollectionAssert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void Secretkey_20_With_Length_8()
        {
            var actual = _digitalCypher.Encode("birthday", 20);
            var expected = new[] { 4, 9, 20, 20, 10, 4, 3, 25 };

            CollectionAssert.AreEqual(expected, actual);
        }
    }
}