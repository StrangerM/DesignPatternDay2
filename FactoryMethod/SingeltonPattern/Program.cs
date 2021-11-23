using System;

namespace SingeltonPattern
{
    class Program
    {
        static void Main(string[] args)
        {
            ProviderToDB provider = ProviderToDB.Instance;
            provider.SqlQuery("select * from obj_Student with(nolock)");
        }
    }
}
