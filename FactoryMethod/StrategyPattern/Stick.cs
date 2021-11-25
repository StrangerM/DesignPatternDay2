using System;
using System.Collections.Generic;
using System.Text;

namespace StrategyPattern
{
    public class Stick : IWork
    {
        public void DoSomeWork()
        {
            Console.WriteLine("Stick wallpaper on the wall ");
        }
    }
}
