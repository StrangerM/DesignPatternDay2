using System;

namespace Flywiight
{
    class Program
    {
        static void Main(string[] args)
        {
            double longittude = 23.6;
            double latitude = 45.9;

            HouseFacory houses = new HouseFacory();

            for (int x = 0; x < 6; x++)
            {
                MonolitHouse panelHouse = (MonolitHouse)houses.GetHouse("Monolit");
                if (panelHouse is null)
                {
                    new MonolitHouse(9).HouseBuilder(longittude, latitude, "Five Avanu str.");
                }

                latitude += 1;
                longittude += 1;
            }
        }
    }
}
