using System;
using System.Collections.Generic;
using System.Text;

namespace ObserverPattern
{
    public class Users : IObserver
    {
        public string Name { get; set; }
        IObservable vodochanel;

        public Users(string name, IObservable obj)
        {
            Name = name;
            vodochanel = obj;
            vodochanel.RegisterObserver(this);
        }
        public void Update(object obj)
        {
            Water water = (Water)obj;
            if (water.Stop)
            {
                Console.WriteLine($"Water was blocked for {Name}");
            }
            else
            {
                Console.WriteLine($"Water start running for {Name}");
            }
        }
        public void StopObserve()
        {
            vodochanel.RemoveObserver(this);
            vodochanel = null;
        }
    }
}
