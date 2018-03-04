using System;

namespace HWNextSmallerNumberWithTheSameDigits
{
    public class NextSmallerNumber
    {
        public static long NextSmaller(int num)
        {
            var number = num.ToString().ToCharArray();

            for (var i = number.Length - 2; i >= 0; i--)
            {
                if (number[i] < number[i + 1])
                {
                    continue;
                }
                var leftPartNum = num.ToString().Substring(0, i + 1).ToCharArray();
                var rightPartNum = num.ToString().Substring(i + 1, number.Length - i - 1).ToCharArray();
                Array.Sort(rightPartNum);
                Array.Reverse(rightPartNum);

                for (var j = 0; j < rightPartNum.Length; j++)
                {
                    if (leftPartNum[i] <= rightPartNum[j]) continue;

                    leftPartNum[i] = rightPartNum[j];
                    rightPartNum[j] = number[i];
                    var result = new string(leftPartNum) + new string(rightPartNum);

                    if (result[0] == '0')
                    {
                        return -1;
                    }
                    return Convert.ToInt64(result); 
                }
            }
            return -1;
        }
    }
}