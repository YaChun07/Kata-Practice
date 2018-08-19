using System;

namespace HWDigitalCypher
{
    public class DigitalCypher
    {
        public int[] Encode(string s, int i)
        {
            var digitalCypher = new int[s.Length];
            var secretKey = i.ToString();

            for (var index = 0; index < s.Length; index++)
            {
                digitalCypher[index] = ConvertAsciiToNum(s[index]) + GetSecretKey(secretKey, index);
            }
            return digitalCypher;
        }

        private int GetSecretKey(string secretKey, int index)
        {
            return Convert.ToInt32(secretKey[index % secretKey.Length].ToString());
        }

        private int ConvertAsciiToNum(char c)
        {
            var diffOfAsciiAndCypherTable = 96;

            return Convert.ToInt32(c) - diffOfAsciiAndCypherTable;
        }
    }
}