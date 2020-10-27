using System;

namespace Temp_M_S
{
    public class InsertionSort : ISort
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
            Console.WriteLine("Insertion of array is started");
            var watch = new System.Diagnostics.Stopwatch();
            watch.Start();
            int i, j;
            int N = data.Length;

            for (j = 1; j < N; j++)
            {
                for (i = j; i > 0 && data[i] < data[i - 1]; i--)
                {
                    exchange(data, i, i - 1);
                }
            }
            watch.Stop();
            var elapsedMs = watch.ElapsedMilliseconds;
            Console.WriteLine("The sorting took : {0}ms", elapsedMs);
        }
    }
}