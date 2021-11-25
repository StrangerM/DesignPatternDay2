using System;
using System.Collections.Generic;
using System.Text;

namespace StrategyPattern
{
    public class SetUp : IWork
    {
        public void DoSomeWork()
        {
            Console.WriteLine("Set up wall ");
        }
    }
}
