using System;
using System.Collections.Generic;
using System.Text;

namespace FirstEXER
{
    public class InvalidDivideExeption : Exception
    {
        public InvalidDivideExeption()
        {
            Console.WriteLine("U cant divide a number with 0, Invalid divide");
        }
    }
}
