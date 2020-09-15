using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using CompressionStocking;

namespace CompressionStockingApplication
{

    public class StubCompressionCtrl : ICompressionCtrl
    {
        private readonly ILED RedLed;
        private readonly ILED GreenLed;
        private bool ComState { get; set; } = false;

        public StubCompressionCtrl(RedLED red, GreenLED Green)
        {
            RedLed = red;
            GreenLed = Green;
        }

        public void Compress()
        {
            if (ComState == false)
            {
                Console.WriteLine("StubCompressionCtrl::Compress() called");
                GreenLed.TurnOn();
                Thread.Sleep(5000);
                Console.WriteLine("StubCompressionCtrl::Compress() Done");
                GreenLed.TurnOff();
                ComState = true;

            }
        }

        public void Decompress()
        {
            if (ComState == true)
            {
                Console.WriteLine("StubCompressionCtrl::Decompress() called");
                RedLed.TurnOn();
                Thread.Sleep(2000);
                Console.WriteLine("StubCompressionCtrl::Decompress() Done");
                GreenLed.TurnOff();
                ComState = false;
            }
        }

    }



    class CompressionStockingApplication
    {
        static void Main(string[] args)
        {
            var compressionStockingstocking = new StockingCtrl(new StubCompressionCtrl(new RedLED(), new GreenLED()));
            ConsoleKeyInfo consoleKeyInfo;
            
            Console.WriteLine("Compression Stocking Control User Interface");
            Console.WriteLine("A:   Compress");
            Console.WriteLine("Z:   Decompress");
            Console.WriteLine("ESC: Terminate application");

            do
            {
                consoleKeyInfo = Console.ReadKey(true); // true = do not echo character
                if (consoleKeyInfo.Key == ConsoleKey.A)  compressionStockingstocking.StartBtnPushed();
                if (consoleKeyInfo.Key == ConsoleKey.Z)  compressionStockingstocking.StopBtnPushed();

            } while (consoleKeyInfo.Key != ConsoleKey.Escape);
        }
    }
}
