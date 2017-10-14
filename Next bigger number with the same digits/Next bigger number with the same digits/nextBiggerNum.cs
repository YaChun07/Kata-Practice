using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Next_bigger_number_with_the_same_digits
{
    public class nextBiggerNum
    {

        public static long NextBiggerNumber(long n)
        {
            char[] num = n.ToString().ToCharArray();
            string result = "";
            for (int i = num.Length - 2; i >= 0; i--)
            {
                if (num[i] < num[i + 1])
                {
                    char[] numLeft = n.ToString().Substring(0, i + 1).ToCharArray();
                    char[] numRight = n.ToString().Substring(i + 1, num.Length - i - 1).ToCharArray();
                    Array.Sort(numRight);
                    for (int j = 0; j < numRight.Length; j++)
                    {
                        
                        if (numLeft[i] < numRight[j])
                        {
                            numLeft[i] = numRight[j];
                            numRight[j] = num[i];
                            result = new string(numLeft) + new string(numRight);
                            return Convert.ToInt64(result);
                        }
                    }
                }
            }
            return -1;
        }


    }
}