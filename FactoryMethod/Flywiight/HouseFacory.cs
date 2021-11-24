using System;
using System.Collections.Generic;
using System.Text;

namespace Flywiight
{
    public class HouseFacory
    {
        Dictionary<string, House> houses = new Dictionary<string, House>();
        public HouseFacory()
        {
            houses.Add("Panel", new PanelHouse(6));
           // houses.Add("Panel", new PanelHouse(9));
            houses.Add("Brick", new BrickHouse());
        }

        public House GetHouse(string key)
        {
            if (houses.ContainsKey(key))
            {
                return houses[key];
            }
            else
            {
                return null;
            }
        }
    }
}
