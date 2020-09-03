using System;
using System.Collections.Generic;
using System.Text;

namespace DoStuff
{
    class DoDickey : IDoThings
    {
        public void DoNothing()
        {
            Console.WriteLine("DoDicket::DoNothing()");
        }

        public int DoSomething(int number)
        {
            Console.WriteLine("DoDicket::DoSomething() : {0}", number);
            return number;
        }

        public string DoSomethingElse(string input)
        {
            Console.WriteLine("DoDicket::DoSomethingElse() : {0}", input);
            return input;
        }
    }
}
