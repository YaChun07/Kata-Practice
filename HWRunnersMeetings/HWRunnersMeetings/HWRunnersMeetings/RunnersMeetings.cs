using System.Collections.Generic;
using System.Linq;

namespace HWRunnersMeetings
{
    internal class RunnersMeetings
    {
        public static int CountMeetPeople(int[] startPosition, int[] speed)
        {
            var positionList = new List<float>();
            var speedList = new List<int>(speed);
            var time = 0;
            var maxPersonCount = 0;
            while (speedList.Count > 1)
            {
                for (var i = 0; i < speedList.Count; i++)
                {
                    positionList.Add((speedList[i] * time) / 60 + startPosition[i]);
                }
                var personcount = positionList.GroupBy(x => x).Max(x => x.Count());

                if (personcount > maxPersonCount)
                {
                    maxPersonCount = personcount;
                }
                var firstRunnerIndex = positionList.IndexOf(positionList.Max());

                if (speedList.Max() == speedList[firstRunnerIndex])
                {
                    speedList.RemoveAt(firstRunnerIndex);
                }
                time++;
                positionList.Clear();
            }
            return maxPersonCount <= 1 ? -1 : maxPersonCount;
        }
    }
}