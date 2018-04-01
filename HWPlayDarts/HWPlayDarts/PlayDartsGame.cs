using System;
using System.Collections.Generic;

namespace HWPlayDarts
{
    internal class PlayDartsGame
    {
        public static string GetScore(double x, double y)
        {
            var scoreTable = new Dictionary<int, int>
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
            var distance = x * x + y * y;
            return GetResult(distance, scoreTable[(int)period]);
        }

        private static string GetResult(double distance, int score)
        {
            var radiusPeriod = new Dictionary<double, string>
            {
                {RadiusSquare(12.70),"DB" },
                {RadiusSquare(31.8),"SB"},
                {RadiusSquare(198),""},
                {RadiusSquare(214),"T"},
                {RadiusSquare(324),"" },
                {RadiusSquare(340),"D"}
            };

            foreach (var radius in radiusPeriod)
            {
                if (distance < radius.Key)
                {
                    if (radius.Value.Length == 2)
                    {
                        return radius.Value;
                    }
                    return radius.Value + score;
                }
            }
            return "X";
        }

        private static double RadiusSquare(double radius)
        {
            return Math.Pow(radius / 2, 2);
        }
    }
}