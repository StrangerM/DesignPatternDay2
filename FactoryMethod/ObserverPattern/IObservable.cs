using System;
using System.Collections.Generic;
using System.Text;

namespace ObserverPattern
{
    public interface IObservable
    {
        void RegisterObserver(IObserver observer);
        void RemoveObserver(IObserver observer);
        void NotifyObserver();
    }
}
