using System;
using System.Collections.Generic;
using System.Text;

namespace StatePattern
{
    public class StoodState : SportsmanState
    {
        public override void SomeState(Sportsman sportsman)
        {
            sportsman.State = new StoodState();
        }
    }
}
