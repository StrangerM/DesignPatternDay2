using System;
using System.Collections.Generic;
using System.Text;

namespace DecoratorPattern
{
    public abstract class ComputerDecorator : BaseComputer
    {
        protected BaseComputer _computer;
        public ComputerDecorator(string name, BaseComputer computer) : base(name)
        {
            _computer = computer;
        }
    }
}
