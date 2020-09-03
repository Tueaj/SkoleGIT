using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Opgave1_5
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("JEG GÆTTER DIG FADME NU!");
            Char Uinput;
            int gæt = 50;
            int antalGæt = 1;
            bool vundet = false;
            while (vundet == false)
            {
                Console.WriteLine("\nJeg gætter på {0}\n", gæt);
                Console.WriteLine("Hjælp, tast L for lower, H for higher eller NOGET ANDET FOR lige på\n");
                Uinput = Console.ReadKey().KeyChar;
                antalGæt++;
                if (Uinput == 'L' || Uinput == 'l')
                    gæt -= 100 / (Convert.ToInt32(Math.Pow(2, antalGæt)));
                else if (Uinput == 'H' || Uinput == 'h')
                    gæt += 100 / (Convert.ToInt32(Math.Pow(2, antalGæt)));
                else
                    vundet = true;
            }
            Console.WriteLine("Jeg vidste det, du er fucking dum makker\n");
            Console.ReadKey();
        }
    }
}
