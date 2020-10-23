using System;

namespace ObserverPStocks
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!, LETS GO");
            Stock DB = new Stock("DanskeBank", 64);
            Stock SyS = new Stock("Systematic", 44);
            Stock LC = new Stock("LindCapital", 11);
            Stock FW = new Stock("FitnessWorld", 33);
            Stock E = new Stock("eRect", 66);

            Portfolio portfolio = new Portfolio();

            portfolio.AddSubject(DB);
            portfolio.AddSubject(SyS);
            portfolio.AddSubject(E);

            Console.WriteLine("eRect price is now 77");
            E.SetPrice(77);

            Console.WriteLine("DanskeBank stock is now priced at 42");
            DB.SetPrice(42);

            Console.ReadKey();
        }
    }
}
