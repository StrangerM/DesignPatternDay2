using System;
using System.Collections.Generic;
using System.Text;

namespace PrototypePattern
{
    public class Region
    {
        public string Name { get; set; }
        public decimal Arrea { get; set; }
        public Region(string name, decimal arrea)
        {
            Name = name;
            Arrea = arrea;
        }
    }
}
