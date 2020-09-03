using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Opgave1_4
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hej med dig din fucking taber: Gæt mig fucking tal\n");
            Random rand = new Random(Guid.NewGuid().GetHashCode());
            int tal = rand.Next(100) + 1;
            bool vundet = false;
            while (vundet == false)
            {
                Console.WriteLine("Skriv et GÆT\n");
                int gæt = Int32.Parse(Console.ReadLine());
                if (gæt > tal)
                    Console.WriteLine("For højt\n");
                else if (gæt < tal)
                    Console.WriteLine("For lavt\n");
                else
                    vundet = true;
            }
            Console.WriteLine("Fair nok så.....");
            Console.ReadKey();
        }
    }
}
