using System;

namespace Temp_M_S
{
    public class ShellSort : ISort
    {
        private void exchange(int[] data, int m, int n)
        {
            int temporary;

            temporary = data[m];
            data[m] = data[n];
            data[n] = temporary;
        }

        public void IntArrayShellSort(int[] data, int[] intervals)
        {
            int i, j, k, m;
            int N = data.Length;

            // The intervals for the shell sort must be sorted, ascending

            for (k = intervals.Length - 1; k >= 0; k--)
            {
                int interval = intervals[k];
                for (m = 0; m < interval; m++)
                {
                    for (j = m + interval; j < N; j += interval)
                    {
                        for (i = j; i >= interval && data[i] < data[i - interval]; i -= interval)
                        {
                            exchange(data, i, i - interval);
                        }
                    }
                }
            }
        }

        public void Sort(int[] data)
        {
            Console.WriteLine("BubbleSort of array is started");
            var watch = new System.Diagnostics.Stopwatch();
            watch.Start();
            int[] intervals = { 1, 2, 4, 8 };
            IntArrayShellSort(data, intervals);
            watch.Stop();
            var elapsedMs = watch.ElapsedMilliseconds;
            Console.WriteLine("The sorting took : {0}ms", elapsedMs);
        }
    }
}