using System;
using System.Collections.Generic;
using System.Text;

namespace PrototypePattern
{
    public abstract class Prototype
    {
        public abstract Prototype DeepCopy();
    }
}
