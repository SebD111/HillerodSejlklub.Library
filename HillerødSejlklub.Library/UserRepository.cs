using System;
using System.Collections.Generic;
using System.Text;

namespace HillerødSejlklub.Library
{
    public class UserRepository
    {
        private static SortedDictionary<string, User> _userData = new SortedDictionary<string, User>();

       


        public void GetAllMembers()
        {
            foreach (var user in _userData.Values)
            {
                Console.WriteLine("Medlemsliste:");
               Console.WriteLine($" Navn: {user.Name} -  ID: {user.Id} - Adresse: {user.Adress} - Telefon: {user.Phone} - Email: {user.Email} - Oprettet: {user.Time}");
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

        public User GetUserById(int id)
        {

            foreach (User user in _userData.Values)
            {

                if (user.Id == id)
                {
                    Console.WriteLine($"Fandt bruger: {user.Name}");
                    return user;
                }
            }

            return null;
        }

        public void UpdateUser(int id, string newAddress = null, string newPhone = null, string newEmail = null)
        {
            User userToEdit = GetUserById(id);

            if (userToEdit != null)
            {

                if (newAddress != null)
                {
                    userToEdit.Adress = newAddress;
                }

                if (newPhone != null)
                {
                    userToEdit.Phone = newPhone;
                }

                if (newEmail != null)
                {
                    userToEdit.Email = newEmail;
                }

                Console.WriteLine($"Ændring er gemt for medlem: {userToEdit.Name}\n");
            }
            else
            {
                Console.WriteLine($"Kunne ikke finde medlem med id: {id}");
            }
        }
    }
}
