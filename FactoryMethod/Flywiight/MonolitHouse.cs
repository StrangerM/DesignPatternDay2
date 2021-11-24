using System;
using System.Collections.Generic;
using System.Text;

namespace Flywiight
{
    public class MonolitHouse : House
    {
        public MonolitHouse(int stages) : base(stages)
        {
            if (stages != 9 && stages != 20)
            {
                throw new ArgumentException("Monolit house can have only 9 or 20 stages");
            }
        }

        public override void HouseBuilder(double longit, double latit, string streetName)
        {
            Console.WriteLine($"Built house from brick with coordinates {longit}, and {latit} on the street {streetName}");
        }
    }
}
