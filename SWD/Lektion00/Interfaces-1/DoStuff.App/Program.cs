using System;
using DoStuff;

namespace ConsoleApp2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Tryk 1 for Hickey og 2 for Dickey\n");
            ConsoleKeyInfo key = Console.ReadKey();
            if (key.KeyChar == '1')
                IDoThings myStuff = new DoHickey();
            else
                IDoThings myStuff = new DoDickey();

            myStuff.DoNothing();
            myStuff.DoSomething(4);
            myStuff.DoSomethingElse("hej hej");
        }
    }
}
