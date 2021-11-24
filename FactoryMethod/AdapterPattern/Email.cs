using System;
using System.Collections.Generic;
using System.Text;

namespace AdapterPattern
{
    public class Email : IMessage
    {
        public void Send(string text)
        {
            Console.WriteLine($"Message : {text}");
            Console.WriteLine("Message was sent by post");
        }
    }
}
