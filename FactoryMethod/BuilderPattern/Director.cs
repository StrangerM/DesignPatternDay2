using System;
using System.Collections.Generic;
using System.Text;

namespace BuilderPattern
{
    public class Director
    {
       private IBuilder _builder;

        public void Construct(IBuilder builder)
        {
            _builder = builder;
        }
    }
}
