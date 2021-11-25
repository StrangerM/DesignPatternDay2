using System;

namespace ObserverPattern
{
    class Program
    {
        static void Main(string[] args)
        {
            Vodocanal vodocanal = new Vodocanal();
            Service service = new Service("Inetrnet provider", vodocanal);
            Entrepreneur entrepreneur = new Entrepreneur("P. P. Ivanov", vodocanal);
            Users user = new Users("I.I Smith", vodocanal);

            vodocanal.BlockTheWater();
        }
    }
}
