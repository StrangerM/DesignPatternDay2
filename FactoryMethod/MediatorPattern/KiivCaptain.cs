using System;
using System.Collections.Generic;
using System.Text;

namespace MediatorPattern
{
    public class KiivCaptain : Captain
    {
        public KiivCaptain(Mediator mediator) : base(mediator)
        {

        }

        public override void Notify(string message)
        {
            Console.WriteLine("Message to Kiiv cap" + message);
        }
    }
}
