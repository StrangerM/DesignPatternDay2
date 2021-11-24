using System;
using System.Collections.Generic;
using System.Text;

namespace AdapterPattern
{
    public class Dove : IOldFashionMessage
    {
        public void KickTheBird(string text)
        {
            Console.WriteLine($"Message {text}");
            Console.WriteLine("Message was sent by dove");
        }
    }
}
