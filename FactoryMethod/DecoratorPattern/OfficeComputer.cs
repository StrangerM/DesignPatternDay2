using System;
using System.Collections.Generic;
using System.Text;

namespace DecoratorPattern
{
    public class OfficeComputer : BaseComputer
    {
        public OfficeComputer() : base("Computer for office")
        {

        }

        public override void Show()
        {
            Console.WriteLine($"Computer - {Name}");
        }
    }
}
