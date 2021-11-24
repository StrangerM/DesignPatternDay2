using System;
using System.Collections.Generic;
using System.Text;

namespace ProxyPattern
{
    public class Proxy : IUserRepository
    {
        DateTime _data = DateTime.Now;
        List<string> users;
        private IUserRepository _repository;

        public Proxy(IUserRepository repository)
        {
            _repository = repository;
        }

        public List<string> GetUserList()
        {
            if (_data.AddSeconds(60) < DateTime.Now )
            {
                _data = DateTime.Now;
                return users = _repository.GetUserList();
            }

            if (users is null)
            {
                users = _repository.GetUserList();
            }

            return users;
        }
    }
}
