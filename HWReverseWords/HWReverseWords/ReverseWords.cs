namespace HWReverseWords
{
    internal class ReverseWords
    {
        public static string ReverseString(string words)
        {
            var result = "";
            var word = words.Split(' ');
            foreach (var ch in word)
            {
                result += Reverse(ch) + ' ';
            }
            return result.Trim();
        }

        public static string Reverse(string word)
        {
            var reverse = "";
            for (var i = word.Length - 1; i >= 0; i--)
            {
                reverse += word[i];
            }
            return reverse;
        }
    }
}