using System;
using System.Collections.Generic;
using System.Text;

namespace ProxyPattern
{
    public interface IUserRepository
    {
        List<string> GetUserList();
    }
}
