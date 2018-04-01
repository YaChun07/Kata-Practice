using System;
using System.Collections.Generic;

namespace HWPlayDarts
{
    internal class PlayDartsGame
    {
        public static string GetScore(double x, double y)
        {
            Dictionary<int, int> scoreTable = new Dictionary<int, int>
                {
                    {0,13},
                    {1,4},
                    {2,18},
                    {3,1},
                    {4,20},
                    {5,5},
                    {6,12},
                    {7,9},
                    {8,14},
                    {9,11},
                    {10,8},
                    {11,16},
                    {12,7},
                    {13,19},
                    {14,3},
                    {15,17},
                    {16,2},
                    {17,15},
                    {18,10},
                    {19,6}
                };

            var angle = Math.Atan2(y, x) / Math.PI * 180;
            if (angle < 0)
            {
                angle += 360;
            }
            var period = (angle - 9) / 18;
            if (period < 0)
            {
                period = 19;
            }

            return GetResult(x * x + y * y, scoreTable[(int)period]);
        }

        private static string GetResult(double distance, int score)
        {
            if (distance < Math.Pow(12.70 / 2, 2))
            {
                return "DB";
            }
            else if (distance < Math.Pow(31.8 / 2, 2))
            {
                return "SB";
            }
            else if (distance < Math.Pow(198 / 2, 2))
            {
                return "" + score;
            }
            else if (distance < Math.Pow(214 / 2, 2))
            {
                return "T" + score;
            }
            else if (distance < Math.Pow(324 / 2, 2))
            {
                return "" + score;
            }
            else if (distance < Math.Pow(340 / 2, 2))
            {
                return "D" + score;
            }
            else
            {
                return "X";
            }
        }
    }
}