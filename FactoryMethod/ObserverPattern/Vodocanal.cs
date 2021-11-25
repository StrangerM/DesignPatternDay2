using System;
using System.Collections.Generic;
using System.Text;

namespace ObserverPattern
{
    public class Vodocanal : IObservable
    {
        List<IObserver> observers;
        Water water;
        public Vodocanal()
        {
            observers = new List<IObserver>();
            water = new Water();
        }
        public void NotifyObserver()
        {
            foreach (var item in observers)
            {
                item.Update(water);
            }
        }

        public void RegisterObserver(IObserver observer)
        {
            observers.Add(observer);
        }

        public void RemoveObserver(IObserver observer)
        {
            observers.Remove(observer);
        }

        public void BlockTheWater()
        {
            water.Stop = true;
            NotifyObserver();
        }
    }
}
