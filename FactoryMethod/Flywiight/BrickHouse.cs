using System;
using System.Collections.Generic;
using System.Text;

namespace Flywiight
{
    public class BrickHouse : House 
    {
        public BrickHouse( ) : base(5)
        {

        }

        public override void HouseBuilder(double longit, double latit, string streetName)
        {
            Console.WriteLine($"Built house from brick with coordinates {longit}, and {latit} on the street {streetName}");
        }
    }
}
