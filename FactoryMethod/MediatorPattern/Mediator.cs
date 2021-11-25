using System;
using System.Collections.Generic;
using System.Text;

namespace MediatorPattern
{
    public abstract class  Mediator
    {
        public abstract void Speek(string message, Captain captain);
    }
}
