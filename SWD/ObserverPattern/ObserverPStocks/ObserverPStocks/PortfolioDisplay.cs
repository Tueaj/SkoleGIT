using System;
using System.Collections.Generic;

namespace ObserverPStocks
{
    public class PortfolioDisplay
    {
        public void PrintPortfolio(List<Stock> portfolioList)
        {
            Console.WriteLine("---------------------------------------------------------------");
            Console.WriteLine("Porfolio:");
            foreach (var stock in portfolioList)
            {
                Console.WriteLine("Stock : {0} for price : {1}", stock.Tag, stock.Price);
            }
            Console.WriteLine("---------------------------------------------------------------");
        }
    }
}