using System;

namespace MediatorPattern
{
    class Program
    {
        static void Main(string[] args)
        {
            DispatcherMediator dispatcher = new DispatcherMediator();
            Captain kiivCap = new KiivCaptain(dispatcher);
            Captain uzhCap = new UzhCaptain(dispatcher);
            Captain lvivCap = new LvivCaptain(dispatcher);

            dispatcher.KiivCaptain = kiivCap;
            dispatcher.UzhCaptain = uzhCap;
            dispatcher.LvivCaptain = lvivCap;

            kiivCap.Speek("Message from Cap");
            uzhCap.Speek("Message from Cap");
            lvivCap.Speek("Message from Cap");
        }
    }
}
