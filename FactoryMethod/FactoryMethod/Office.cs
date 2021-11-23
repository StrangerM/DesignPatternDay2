using AbstractFactory.Cargo;
using AbstractFactory.Transport;
using System;
using System.Collections.Generic;
using System.Text;

namespace AbstractFactory
{
    public class Office
    {
        public void CreateRequest(ITransport transport, ICargo cargo, string address)
        {
            Delivery(transport, cargo, address);
        }

        private void Delivery(ITransport transport, ICargo cargo, string address)
        {
            Console.WriteLine(transport.GetType().Name + " was delivered " + cargo.GetType().Name + " to address - " + address); 
        }
    }
}
