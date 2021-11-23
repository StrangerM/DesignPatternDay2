using System;
using System.Collections.Generic;
using System.Text;

namespace BuilderPattern
{
    public interface IBuilder
    {
        void BasicCar();
        void PremiumCar();
        void SuperMegaCar();
    }
}
