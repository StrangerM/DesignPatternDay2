using System;

namespace BuilderPattern
{
    class Program
    {
        static void Main(string[] args)
        {
            Director director = new Director();
            Builder a2 = new A2();
            Builder a5 = new A5();

            director.ConstructPremium(a2);
            director.ConstructSuperMega(a5);

            Product product1 = a2.GetCar();
            product1.Show();

            Product product2 = a5.GetCar();
            product2.Show();
        }
    }
}
