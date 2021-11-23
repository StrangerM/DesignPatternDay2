using System;
using System.Collections.Generic;
using System.Text;

namespace PrototypePattern
{
    public class Cities
    {
        public string Name { get; set; }
        public int Population { get; set; }
        public Cities(string name, int population)
        {
            Name = name;
            Population = population;
        }
    }
}
