using System;

namespace Temp_M_S
{
    public class BubbleSort : ISort
    {
        private void exchange(int[] data, int m, int n)
        {
            int temporary;

            temporary = data[m];
            data[m] = data[n];
            data[n] = temporary;
        }
        public void Sort(int[] data)
        {
            Console.WriteLine("BubbleSort of array is started");
            var watch = new System.Diagnostics.Stopwatch();
            watch.Start();
            int i, j;
            int N = data.Length;

            for (j = N - 1; j > 0; j--)
            {
                for (i = 0; i < j; i++)
                {
                    if (data[i] > data[i + 1])
                        exchange(data, i, i + 1);
                }
            }
            watch.Stop();
            var elapsedMs = watch.ElapsedMilliseconds;
            Console.WriteLine("The sorting took : {0}ms", elapsedMs);
        }
    }
}