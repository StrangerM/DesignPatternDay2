using System;
using System.Collections.Generic;
using System.Text;

namespace MediatorPattern
{
    public abstract class Captain
    {
        protected Mediator _mediator;
        public Captain(Mediator mediator)
        {
            _mediator = mediator;
        }
        public abstract void Notify(string message);

        public virtual void Speek(string message)
        {
            _mediator.Speek(message, this);
        }
    }
}
