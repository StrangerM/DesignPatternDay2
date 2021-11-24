using System;
using System.Collections.Generic;
using System.Text;

namespace AdapterPattern
{
    public class Adapter : IMessage
    {
        IOldFashionMessage _message;

        public Adapter(IOldFashionMessage message)
        {
            _message = message;
        }

        public void Send(string text)
        {
            _message.KickTheBird(text);
        }
    }
}
