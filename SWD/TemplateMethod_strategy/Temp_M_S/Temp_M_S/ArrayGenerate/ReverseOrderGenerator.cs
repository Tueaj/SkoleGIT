using System;

namespace Temp_M_S
{
    public class ReverseOrderGenerator : IArrayGenerator
    {
        public int[] GenerateArray(int n, int max = 0, int seed = 0)
        {

            int[] data = new int[n];

            for (var i = 0; i < n; i++)
            {
                data[i] = n - i;
            }

            return data;
        }
    }
}