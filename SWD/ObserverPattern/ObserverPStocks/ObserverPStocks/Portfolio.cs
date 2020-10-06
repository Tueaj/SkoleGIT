using System.Collections.Generic;

namespace ObserverPStocks
{
    public class Portfolio : IObserver<int>
    {
        public List<Stock> Stocks { get; set; }

        public void Update(int price)
        {
            
        }
    }
}