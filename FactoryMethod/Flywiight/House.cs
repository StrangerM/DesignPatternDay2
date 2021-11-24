using System;
using System.Collections.Generic;
using System.Text;

namespace Flywiight
{
    public abstract class House
    {
        protected int _stages;
        public House(int stages)
        {
            _stages = stages;   
        }

        public abstract void HouseBuilder(double longit, double latit, string streetName);
    }
}
