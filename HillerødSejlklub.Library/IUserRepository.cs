using System;
using System.Collections.Generic;
using System.Text;

namespace HillerødSejlklub.Library
{
    public interface IUserRepository
    {
        // Metoder
        List<User> GetAll();
        User GetByName(string userName);
        User GetById(int id);
        void RemoveByName(string UserName);
        void Update(int id, string newAddress = null, string newPhone = null, string newEmail = null);
        void Add(User user);
    }
}
