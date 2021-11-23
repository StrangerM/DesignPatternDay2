using System;
using System.Collections.Generic;
using System.Text;

namespace BuilderPattern
{
    public class Car : IBuilder
    {
        public int EngineCapacity { get; set; }
        public int Disk { get; set; }
        public void BasicCar()
        {
            throw new NotImplementedException();
        }

        public void PremiumCar()
        {
            throw new NotImplementedException();
        }

        public void SuperMegaCar()
        {
            throw new NotImplementedException();
        }
    }
}
