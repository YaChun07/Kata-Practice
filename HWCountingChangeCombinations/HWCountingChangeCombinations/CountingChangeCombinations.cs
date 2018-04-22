using System;
using System.Linq;

namespace HWCountingChangeCombinations
{
    internal class CountingChangeCombinations
    {
        public static int CountCombinations(int money, int[] coins)
        {
            Array.Sort(coins);
            var count = 0;

            if (coins.Length == 1)
            {
                return money % coins[0] == 0 ? 1 : 0;
            }

            for (var i = 0; i * coins[0] <= money; i++)
            {
                if (i * coins[0] == money)
                {
                    count += 1;
                }
                else
                {
                    count += CountCombinations(money - i * coins[0], coins.Skip(1).ToArray());
                }
            }

            return count;
        }
    }
}