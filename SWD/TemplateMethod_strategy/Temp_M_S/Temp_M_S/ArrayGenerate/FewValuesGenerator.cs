using System;

namespace Temp_M_S
{
    public class FewValuesGenerator : IArrayGenerator
    {
        public int[] GenerateArray(int n, int max, int seed)
        {
            var ran = new Random(seed);
            var data = new int[n];

            for (var i = 0; i < n; i++)
            {
                data[i] = ran.Next(10);
            }

            return data;
        }
    }
}