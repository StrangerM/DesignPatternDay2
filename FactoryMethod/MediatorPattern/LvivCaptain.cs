using System;
using System.Collections.Generic;
using System.Text;

namespace MediatorPattern
{
    public class LvivCaptain : Captain
    {
        public LvivCaptain(Mediator mediator) : base(mediator)
        {

        }

        public override void Notify(string message)
        {
            Console.WriteLine("Message to Lviv cap" + message);
        }
    }
}
