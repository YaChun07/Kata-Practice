using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace HWReverseWords
{
    [TestClass]
    public class ReverseWordsTest
    {
        [TestMethod]
        public void string_with_sentence()
        {
            Assert.AreEqual("sihT si na !elpmaxe", ReverseWords.ReverseString("This is an example!"));
        }

        [TestMethod]
        public void string_with_digits()
        {
            Assert.AreEqual("54321", ReverseWords.ReverseString("12345"));
        }

        [TestMethod]
        public void string_with_synbol()
        {
            Assert.AreEqual("!@# $%", ReverseWords.ReverseString("#@! %$"));
        }

    }
}