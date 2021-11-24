using System;

namespace ProxyPattern
{
    class Program
    {
        static void Main(string[] args)
        {
            IUserRepository repository = new Proxy(new VodafoneUserRepository());
            var list = repository.GetUserList();

            foreach (var item in list)
            {
                Console.WriteLine(item);
            }
        }
    }
}
