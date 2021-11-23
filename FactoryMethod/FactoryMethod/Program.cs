using AbstractFactory.Cargo;
using System;

namespace AbstractFactory
{
    class Program
    {
        static void Main(string[] args)
        {
            Office office = new Office();

            office.CreateRequest(new ShipFactory().CreateTransport(), new Stone("small stone"),  "USA");
            office.CreateRequest(new ShipFactory().CreateTransport(), new Stone("small stone"), "GB");
            office.CreateRequest(new PlaneFactory().CreateTransport(), new Stone("small stone"), "UA");
            office.CreateRequest(new TruckFactory().CreateTransport(), new Stone("small stone"), "FRA");
            office.CreateRequest(new TruckFactory().CreateTransport(), new Stone("small stone"), "CA");
            office.CreateRequest(new TruckFactory().CreateTransport(), new Stone("small stone"), "GE");
            office.CreateRequest(new TruckFactory().CreateTransport(), new Stone("small stone"), "HU");

        }
    }
}
