using System;
using System.Collections.Generic;
using System.Text;

namespace DecoratorPattern
{
    public abstract class BaseComputer
    {
        public string Name { get; set; }
        public BaseComputer(string name)
        {
            Name = name;
        }

        public abstract void Show();
    }
}
