using AbstractFactory.Cargo;
using AbstractFactory.Transport;
using System;
using System.Collections.Generic;
using System.Text;

namespace AbstractFactory
{
    public class ShipFactory : TransportFactory
    {
        public override ITransport CreateTransport()
        {
            return transport = new Ship();
        }
    }
}
