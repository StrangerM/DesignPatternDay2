using System;
using System.Collections.Generic;
using System.Text;

namespace StatePattern
{
    public abstract class SportsmanState
    {
        public abstract void SomeState(Sportsman sportsman);
    }
}
