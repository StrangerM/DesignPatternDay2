using AbstractFactory.Cargo;
using System;
using System.Collections.Generic;
using System.Text;

namespace AbstractFactory.Transport
{
    public class Plane : ITransport
    {
        public string Address { get; private set; }
    }
}
