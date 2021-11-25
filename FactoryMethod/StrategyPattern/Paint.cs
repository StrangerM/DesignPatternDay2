using System;
using System.Collections.Generic;
using System.Text;

namespace StrategyPattern
{
    public class Paint : IWork
    {
        public void DoSomeWork()
        {
            Console.WriteLine("Paint the wall");
        }
    }
}
