using System;
using System.Collections.Generic;
using System.Text;

namespace ObserverPStocks
{
    public class Stock :ISubject<int>
    {
        private List<IObserver<int>> observers = new List<IObserver<int>>();

        public int Price { get; set; }

        public void Attach(IObserver<int> obs)
        {
            observers.Add(obs);
        }

        public void Detach(IObserver<int> obs)
        {
            observers.Remove(obs);
        }

        public void Notify()
        {
            foreach (var observer in observers)
            {
                observer.Update(Price);
            }
        }

    }
}
