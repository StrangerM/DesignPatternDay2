using System;

namespace AdapterPattern
{
    class Program
    {
        static void Main(string[] args)
        {
            var adapter = new Adapter(new Dove());
            adapter.Send("Message");
        }
    }
}
