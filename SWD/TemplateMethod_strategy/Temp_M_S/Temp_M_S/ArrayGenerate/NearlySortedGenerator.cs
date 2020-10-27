using System;

namespace Temp_M_S
{
    public class NearlySortedGenerator : IArrayGenerator
    {
        public int[] GenerateArray(int n, int max, int seed)
        {
            var ran = new Random(seed);

            var unsorted = new int[n];

            for (var i = 0; i < n; i++)
            {
                if (ran.Next(5) == 1)
                {
                    unsorted[i] = ran.Next(max);
                }
                else
                {
                    unsorted[i] = i;
                }
            }

            return unsorted;
        }
    }
}