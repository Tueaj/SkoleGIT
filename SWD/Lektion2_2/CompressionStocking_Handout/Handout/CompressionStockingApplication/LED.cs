using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CompressionStockingApplication
{
    interface ILED
    {
        void TurnOn();
        void TurnOff();
    } 

    public class RedLED : ILED
    {
        public void TurnOn()
        {
            Console.WriteLine("Red LED is ON");
        }

        public void TurnOff()
        {
            Console.WriteLine("Red LED is OFF");
        }
    }

    public class GreenLED : ILED
    {
        public void TurnOn()
        {
            Console.WriteLine("Green LED is ON");
        }

        public void TurnOff()
        {
            Console.WriteLine("Green LED is OFF");
        }
    }
}
