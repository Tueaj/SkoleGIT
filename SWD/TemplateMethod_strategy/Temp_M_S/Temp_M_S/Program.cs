using System;

namespace Temp_M_S
{
    class Program
    {
        static void Main(string[] args)
        {
            int lengthOfArray = 100;
            int maxSizeInArray = 10;
            int seed = 10;
            ArrayGenerator AG = new ArrayGenerator();
            int[] array = AG.GenerateArray(lengthOfArray, maxSizeInArray, seed);
            for  (int i=0; i< array.Length; i++)
            {
                Console.WriteLine("place number {0} in array contains {1}",i,array[i]);
            }
            var watch = new System.Diagnostics.Stopwatch();
            watch.Start();
            AG.quickSort(array, 0, lengthOfArray-1);
            Console.WriteLine("Array after quick sort");
            for (int i = 0; i < array.Length; i++)
            {
                Console.WriteLine("place number {0} in array contains {1}", i, array[i]);
            }
            watch.Stop();
            var elapsedMs = watch.ElapsedMilliseconds;
            Console.WriteLine("The sorting took : {0}ms",elapsedMs);
        }

    }
}
