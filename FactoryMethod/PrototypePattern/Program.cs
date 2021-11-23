using System;
using System.Collections.Generic;

namespace PrototypePattern
{

    class Program
    {
        static void Main(string[] args)
        {
            List<Cities> cities = new List<Cities>
            {
                new Cities("Uzhgorod", 150000),
                new Cities("Kiiv", 3000000),
                new Cities("Lviv", 200000)
            };

            List<Region> regions = new List<Region>()
            {
                new Region("Zakarpatska obl", 300000),
                new Region("Lvivska obl", 40000),
                new Region("Zaporizka obl", 8000),
            };

            Country country1 = new Country("Ukraine", cities, regions);

            country1.Show();

            Country country2 = country1.DeepCopy();
            Console.WriteLine("========");

            country2.ChangeCity("Uzhgorod", "Kharkiv", 1500000);
            country2.ChangeRegion("Zakarpatska obl", "Volinska", 10000);

            Console.WriteLine("========");
            country1.Show();

            Console.WriteLine("========");

            country2.Show();

        }
    }
}
