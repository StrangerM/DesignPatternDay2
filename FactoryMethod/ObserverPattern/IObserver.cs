using System;
using System.Collections.Generic;
using System.Text;

namespace ObserverPattern
{
    public interface IObserver
    {
        void Update(object obj);
    }
}
