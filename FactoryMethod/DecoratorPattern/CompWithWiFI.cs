using System;
using System.Collections.Generic;
using System.Text;

namespace DecoratorPattern
{
    public class CompWithWiFI : ComputerDecorator
    {
        public CompWithWiFI(BaseComputer computer) : base(computer.Name + " with WI FI", computer)
        {

        }
        public override void Show()
        {
            Console.WriteLine($"Ordered {Name}");
        }
    }
}
