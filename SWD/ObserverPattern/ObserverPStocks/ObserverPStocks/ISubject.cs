using System;
using System.Collections.Generic;
using System.Text;

namespace ObserverPStocks
{
    public interface ISubject<T>
    {
        void Attach(IObserver<T> obs);
        void Detach(IObserver<T> obs);
        void Notify();

    }
}
