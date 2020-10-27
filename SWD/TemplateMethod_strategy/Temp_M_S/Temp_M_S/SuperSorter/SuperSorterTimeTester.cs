namespace Temp_M_S
{
    public class SuperSorterTimeTester : ISuperSorter
    {
        public ISort Sort { get; set; }

        private ISort[] SortArray { get; set; }

        public SuperSorterTimeTester()
        {
            SortArray = new ISort[]{new BubbleSort(), new InsertionSort(), new QuickSort(), new ShellSort()};
        }
        public void TestSortingTime(int[] arr)
        {
            foreach (var s in SortArray)
            {
                s.Sort(arr);
            }
        }
    }
}