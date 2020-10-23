using System;
using System.Collections.Generic;
using System.Text;

namespace ObserverPStocks
{
    public interface ISubject
    {
        void Attach(IObserver obs);
        void Detach(IObserver obs);
        void Notify();

    }
}
