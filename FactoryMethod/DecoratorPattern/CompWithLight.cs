using System;
using System.Collections.Generic;
using System.Text;

namespace DecoratorPattern
{
    public class CompWithLight : ComputerDecorator
    {
        public CompWithLight(BaseComputer computer) : base(computer.Name + " with light", computer)
        {

        }
        public override void Show()
        {
            Console.WriteLine($"Ordered {Name}");
        }
    }
}
