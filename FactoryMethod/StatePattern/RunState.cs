using System;
using System.Collections.Generic;
using System.Text;

namespace StatePattern
{
    public class RunState : SportsmanState
    {
        public override void SomeState(Sportsman sportsman)
        {
            sportsman.State = new RunState();
        }
    }
}
