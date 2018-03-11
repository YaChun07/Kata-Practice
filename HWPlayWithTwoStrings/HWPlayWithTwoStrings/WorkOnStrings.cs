using System.Linq;

namespace HWPlayWithTwoStrings
{
    internal class WorkOnStrings
    {
        public string CombineString(string stringA, string stringB)
        {
            var result = PlayWithTwoString(stringA, stringB)+PlayWithTwoString(stringB,stringA);

            return result;
        }

        private string PlayWithTwoString(string stringA, string stringB)
        {
            string result = "";

            for (int i = 0; i < stringA.Length; i++)
            {
                int duplicateCount = stringB.ToLower().ToCharArray().Count(c => c == char.ToLower(stringA[i]));

                if (duplicateCount % 2 == 1)
                {
                    result += ChangeCharater(stringA[i]);
                }
                else
                {
                    result += stringA[i];
                }
            }
            return result;
        }

        private char ChangeCharater(char charater)
        {
            return char.IsUpper(charater) ? char.ToLower(charater) : char.ToUpper(charater);
        }
    }
}