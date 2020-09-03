using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CardGame
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Game starts\n How many players?:");
            int x = int.Parse(Console.ReadLine());
            Game lol = new Game(x);
        }
    }
}
