using System;
using System.Collections.Generic;
using System.Text;

namespace HillerødSejlklub.Library
{
    public class UserRepository
    {
        private List<User> _users = new List<User>();

        public void GetAllMembers()
        {
            foreach (var user in _users)
            {
               
               Console.WriteLine($" Navn: {user.Name} -  ID: {user.Id} - Adresse: {user.Adress} - Telefon: {user.Phone} - Email: {user.Email}");
            }
        }

     

        public User GetUsersByName(string UserName)
        {
            foreach (User user in _users)
            {
                if (user.Name == UserName)
                {
                    return user;
                }
            }
            return null;
        }

      
    }
}
