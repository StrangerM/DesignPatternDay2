using System;
using System.Collections.Generic;
using System.Text;

namespace AdapterPattern
{
    public interface IMessage
    {
        void Send(string text);
    }
}
