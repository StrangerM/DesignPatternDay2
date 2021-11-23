using System;
using System.Collections.Generic;
using System.Text;

namespace AbstractFactory.Cargo
{
    public class Stone : ICargo
    {
        public string NameofCargo { get; }
        public Stone(string name)
        {
            name = NameofCargo;
        }

        public Stone()
        {
        }
    }
}
