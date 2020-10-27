using System;
using System.Runtime.CompilerServices;

namespace Temp_M_S
{
    public class RandomArrayGenerator : IArrayGenerator
    {
        public int[] GenerateArray(int n, int max, int seed)
        {
            int[] tempArray = new int[n];
            Random rnd = new Random();
            for (int i = 0; i < tempArray.Length; i++)
            {
                tempArray[i] = rnd.Next(0, max);
            }
            return tempArray;
        }
    }
}