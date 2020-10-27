using System;

namespace Temp_M_S
{
    public class QuickSort : ISort
    {

        private void exchange(int[] data, int m, int n)
        {
            int temporary;

            temporary = data[m];
            data[m] = data[n];
            data[n] = temporary;
        }
        public void Sort(int[] arr, int low, int high)
        {
            int i, j;
            int x;

            i = low;
            j = high;

            x = arr[(low + high) / 2]; /* find pivot item */
            while (true)
            {
                while (arr[i] < x)
                    i++;
                while (x < arr[j])
                    j--;
                if (i <= j)
                {
                    exchange(arr, i, j);
                    i++;
                    j--;
                }
                if (i > j)
                    break;
            }
            if (low < j)
                Sort(arr, low, high);
            if (i < high)
                Sort(arr, low, high);
        }

        public void Sort(int[] arr)
        {
            Console.WriteLine("BubbleSort of array is started");
            var watch = new System.Diagnostics.Stopwatch();
            watch.Start();
            Sort(arr, 0, arr.Length-1);
            watch.Stop();
            var elapsedMs = watch.ElapsedMilliseconds;
            Console.WriteLine("The sorting took : {0}ms", elapsedMs);
        }
    }
}