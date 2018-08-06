namespace HWGetMiddleCharacter
{
    public class GetMiddleCharacter
    {
        public static string GetMiddle(string s)
        {
            return IsStringLengthEven(s) ? GetMiddleTwoChar(s) : GetMiddleChar(s);
        }

        private static string GetMiddleChar(string s)
        {
            return s[s.Length / 2].ToString();
        }

        private static bool IsStringLengthEven(string s)
        {
            return s.Length % 2 == 0;
        }

        private static string GetMiddleTwoChar(string s)
        {
            return s[s.Length / 2 - 1].ToString() + s[s.Length / 2];
        }
    }
}