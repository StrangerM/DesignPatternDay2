using System;
using System.Collections.Generic;
using System.Text;

namespace Flywiight
{
    public class PanelHouse : House
    {
        public PanelHouse(int stages) : base(stages)
        {
            if (stages != 9 && stages != 6)
            {
                throw new ArgumentException("Monolit house can have only 9 or 6 stages");
            }
        }

        public override void HouseBuilder(double longit, double latit, string streetName)
        {
            Console.WriteLine($"Built house from brick with coordinates {longit}, and {latit} on the street {streetName}");
        }
    }
}
