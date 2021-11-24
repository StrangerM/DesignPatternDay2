using AbstractFactory.Cargo;
using AbstractFactory.Transport;
using System;
using System.Collections.Generic;
using System.Text;

namespace AbstractFactory
{
    public abstract class TransportFactory
    {
        protected ITransport transport;
        public abstract ITransport CreateTransport();
    }
}
