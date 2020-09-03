using System;
using System.Collections.Generic;
using System.Text;

namespace DoStuff
{
    class DoHickey : IDoThings
    {
        public void DoNothing() 
        {
            Console.WriteLine("DoHicket::DoNothing()");
        }
        public int DoSomething(int number)
        {
            Console.WriteLine("DoHicket::DoSomething() : {0}",number);
            return number;
        }
        public string DoSomethingElse(string input)
        {
            Console.WriteLine("DoHicket::DoSomethingElse() : {0}", input);
            return input;
        }
    }
}
