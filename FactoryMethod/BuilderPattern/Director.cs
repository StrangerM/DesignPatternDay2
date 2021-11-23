using System;
using System.Collections.Generic;
using System.Text;

namespace BuilderPattern
{
    public class Director
    {
       private Builder _builder;

        public void ConstructBasic(Builder builder)
        {
            _builder = builder;
            builder.BasicCar();
        }

        public void ConstructPremium(Builder builder)
        {
            _builder = builder;
            builder.PremiumCar();
        }

        public void ConstructSuperMega(Builder builder)
        {
            _builder = builder;
            builder.SuperMegaCar();
        }
    }
}
