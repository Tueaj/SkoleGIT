using System.Collections.Generic;

namespace ObserverPStocks
{
    public class Portfolio : IObserver
    {
        public readonly List<Stock> Stocks = new List<Stock>();

        private readonly PortfolioDisplay _portfolioDisplay = new PortfolioDisplay();

        public void Update()
        {
            _portfolioDisplay.PrintPortfolio(this.Stocks);
        }

        public void AddSubject(ISubject subject)
        {
            Stocks.Add((Stock)subject);
            subject.Attach(this);
        }
    }
}