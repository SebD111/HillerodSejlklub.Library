using System;
using System.Collections.Generic;
using System.Text;

namespace HillerødSejlklub.Library
{
    public class UserRepository
    {
        private static Dictionary<string, User> _userData = new Dictionary<string, User>();

        public void GetAllMembers()
        {
            foreach (var user in _userData.Values)
            {
               Console.WriteLine($" Navn: {user.Name} -  ID: {user.Id} - Adresse: {user.Adress} - Telefon: {user.Phone} - Email: {user.Email}");
            }
        }

        public static User AddUser(User user)
        {
            _userData.Add(user.Name, user);
            return user;
        }

        public User GetUsersByName(string userName)
        {
            foreach (var user in _userData.Values)
            {
                if (user.Name == userName)
                {
                    return user;
                }
            }
            return null;
        }

        public User RemoveUserByName(string UserName)
        {
            User UserRemove = GetUsersByName(UserName);

            if (UserRemove != null)
            {
                _userData.Remove(UserRemove.Name);
                Console.WriteLine("Medlem Fjernet:");
                return UserRemove;
            }
            return null;
        }
    }
}
