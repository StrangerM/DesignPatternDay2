using System;
using System.Collections.Generic;
using System.Text;

namespace PrototypePattern
{
    public class Country
    {
        private string _name;

        private List<Cities> _cities;
        private List<Region> _regions;
        public Country(string name, List<Cities> cities, List<Region> regions)
        {
            _name = name;
            _cities = cities;
            _regions = regions;
        }

       public void Show()
       {
            Console.WriteLine($"{_name} has {_cities.Count} and {_regions.Count}");
            Console.WriteLine("Cities with population:");
            foreach (var item in _cities)
            {
                Console.WriteLine(item.Name + ": with population" + item.Population);
            }

            Console.WriteLine("Regions ");

            foreach (var item in _regions)
            {
                Console.WriteLine(item.Name + ": with arrea" + item.Arrea);
            }
       }

        public void ChangeCity(string oldName, string newName, int population)
        {
            for (int x = 0; x < _cities.Count; x++)
            {
                if (_cities[x].Name == oldName)
                {
                    _cities[x].Name = newName;
                }

                if (_cities[x].Population > population)
                {
                    _cities[x].Population += population;
                }
            }
        }

        public void ChangeRegion(string oldName, string newName, decimal arrea)
        {
            for (int x = 0; x < _regions.Count; x++)
            {
                if (_regions[x].Name == oldName)
                {
                    _regions[x].Name = newName;
                }

                if (_regions[x].Arrea > arrea)
                {
                    _regions[x].Arrea += arrea;
                }
            }
        }

        public Country DeepCopy()
        {
            Country country = this.MemberwiseClone() as Country;
            country._cities = new List<Cities>();
            country._regions = new List<Region>();

            foreach (var item in this._cities)
            {
                var city = new Cities(item.Name, item.Population);
                country._cities.Add(city);
            }

            foreach (var item in this._regions)
            {
                var region = new Region(item.Name, item.Arrea);
                country._regions.Add(region);
            }

            return country;
        }
    }
}
