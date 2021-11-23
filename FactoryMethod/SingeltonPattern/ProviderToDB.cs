using System;
using System.Collections.Generic;
using System.Text;

namespace SingeltonPattern
{
    public class ProviderToDB
    {
        private static ProviderToDB provider = new ProviderToDB();
        private ProviderToDB() { }

        public static ProviderToDB Instance
        {
            get
            {
                return provider;
            }
        }

        public void SqlQuery(string query)
        {
            Console.WriteLine(query);
        }
    }
}
