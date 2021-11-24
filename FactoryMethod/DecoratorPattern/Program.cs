using System;

namespace DecoratorPattern
{
    class Program
    {
        static void Main(string[] args)
        {
            GameComputer gameComputer = new GameComputer();

            new CompWithLight(gameComputer).Show();
            new CompWithWiFI(gameComputer).Show();
        }
    }
}
