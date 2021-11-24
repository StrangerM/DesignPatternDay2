using System;
using System.Collections.Generic;
using System.Text;

namespace DecoratorPattern
{
    public class WorkComputer : BaseComputer
    {
        public WorkComputer() : base("Computer for work")
        {

        }
        public override void Show()
        {
            Console.WriteLine($"Name is {Name}");
        }
    }
}
