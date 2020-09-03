using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lektion1
{
    class Program
    {
        static void Main(string[] args)
        {
            SumMaskine SM1 = new SumMaskine();
            SM1.Velkommen();
        }
    }

    public class SumMaskine
    {
        public SumMaskine() { }
        public void Velkommen()
        {
                Console.WriteLine("Hej med dig, skriv det første tal, jeg skal ligge sammen for dig\n");
                var tal1 = Int32.Parse(Console.ReadLine());
                Console.WriteLine("Hej igen, skrive det næste tal");
                var tal2 = Int32.Parse(Console.ReadLine());
                Sum(tal1, tal2);
            Console.ReadKey();
        }
        
        public void Sum(int tal1, int tal2)
        {
            Console.WriteLine("SUmmen er: {0}", tal1 + tal2);
        }
    }
}
