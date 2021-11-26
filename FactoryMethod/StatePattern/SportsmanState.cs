using System;
using System.Collections.Generic;
using System.Text;

namespace StatePattern
{
    public abstract class SportsmanState
    {
        protected Sportsman _context;

        public virtual void StateRun(Sportsman sportsman)
        {
            _context.TransitionTo(new RunState());
        }

        public virtual void StateStood(Sportsman sportsman)
        {
            _context.TransitionTo(new StoodState());
        }

        public virtual void StateWalk(Sportsman sportsman)
        {
            _context.TransitionTo(new WalkState());
        }

        public void SetContext(Sportsman context)
        {
            this._context = context;
        }
    }
}
