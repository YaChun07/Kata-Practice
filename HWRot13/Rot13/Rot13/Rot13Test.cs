using System;
using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Rot13
{
    [TestClass]
    public class Rot13Test
    {
        [TestMethod]
        public void TestExample()
        {
            Assert.AreEqual("ROT13 example.", decode.Rot13("EBG13 rknzcyr."));
        }

        [TestMethod]
        public void TestExample1()
        {
            Assert.AreEqual("This is my first ROT13 excercise!" , decode.Rot13("Guvf vf zl svefg EBG13 rkprepvfr!"));
        }
        [TestMethod]
        public void String_with_symbol()
        {
            Assert.AreEqual("Hi! This is Amanda~", decode.Rot13("Uv! Guvf vf Nznaqn~"));
        }

        [TestMethod]
        public void Null_point()
        {
            Assert.AreEqual("Not Exist", decode.Rot13(""));
        }
    }

    internal class decode
    {
        public static string Rot13(string input)
        {
            Dictionary<char, char> letter = new Dictionary<char, char>()
            {
                { 'a','n'},
                { 'b','o'},
                { 'c','p'},
                { 'd','q'},
                { 'e','r'},
                { 'f','s'},
                { 'g','t'},
                { 'h','u'},
                { 'i','v'},
                { 'j','w'},
                { 'k','x'},
                { 'l','y'},
                { 'm','z'},
                { 'n','a'},
                { 'o','b'},
                { 'p','c'},
                { 'q','d'},
                { 'r','e'},
                { 's','f'},
                { 't','g'},
                { 'u','h'},
                { 'v','i'},
                { 'w','j'},
                { 'x','k'},
                { 'y','l'},
                { 'z','m'},

            };

            string rotString = "";
            if (String.IsNullOrEmpty(input))
            {
                return "Not Exist";
            }

            for (int i = 0; i < input.Length; i++)
            {
                if (letter.ContainsKey(input.ToLower()[i]))
                {
                    char inputChar = input[i];
                   
                    if (Char.IsUpper(inputChar))
                    {
                        rotString += Char.ToUpper(letter[Char.ToLower(inputChar)]);
                    }
                    else
                    {
                        rotString += letter[inputChar];
                    }
                }
                else
                {
                    rotString += input[i];
                }
                
            }
            return rotString;
        }
    }
}
