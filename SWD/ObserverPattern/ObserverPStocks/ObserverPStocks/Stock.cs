using System;
using System.Collections.Generic;
using System.Text;

namespace ObserverPStocks
{
    public class Stock :ISubject
    {
        private readonly List<IObserver> _observers = new List<IObserver>();

        public Stock(string tag, int price)
        {
            Tag = new string(tag);
            if (price >= 0)
                Price = price;
        }

        public int Price { get; set; }

        public readonly string Tag;

        public void SetPrice(int price)
        {
            if (price < 0) throw new ArgumentOutOfRangeException(nameof(price));
            Price = price;
            Notify();
        }

        public void Attach(IObserver obs)
        {
            _observers.Add(obs);
        }

        public void Detach(IObserver obs)
        {
            _observers.Remove(obs);
        }

        public void Notify()
        {
            foreach (var observer in _observers)
            {
                observer.Update();
            }
        }

    }
}
