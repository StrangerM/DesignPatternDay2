using System;
using System.Collections.Generic;
using System.Text;

namespace MediatorPattern
{
    public class DispatcherMediator : Mediator
    {
        public Captain KiivCaptain { get; set; }
        public Captain LvivCaptain { get; set; }
        public Captain UzhCaptain { get; set; }
        public override void Speek(string message, Captain captain)
        {
            if (KiivCaptain == captain)
            {
                KiivCaptain.Notify(message);
            }

            if (LvivCaptain == captain)
            {
                LvivCaptain.Notify(message);
            }

            if (UzhCaptain == captain)
            {
                UzhCaptain.Notify(message);
            }
        }
    }
}
