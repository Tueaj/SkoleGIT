using System;
using DoStuff;

namespace ConsoleApp2
{
    class Program
    {
        static void Main(string[] args)
        {
            IDoThings myStuff = new DoHickey();
            myStuff.DoNothing();
            myStuff.DoSomething(4);
            myStuff.DoSomethingElse("hej hej");
        }
    }
}
