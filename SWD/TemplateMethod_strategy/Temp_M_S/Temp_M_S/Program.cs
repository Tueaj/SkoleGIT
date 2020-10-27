using System;

namespace Temp_M_S
{
    class Program
    {
        static void Main(string[] args)
        {
           SuperSorterTimeTester superSorterTest = new SuperSorterTimeTester();
           IArrayGenerator arrayGenerator = new RandomArrayGenerator();
           int[] array = arrayGenerator.GenerateArray(10000, 100, 1235213);

           superSorterTest.TestSortingTime(array);

           Console.ReadKey();
        }

    }
}
