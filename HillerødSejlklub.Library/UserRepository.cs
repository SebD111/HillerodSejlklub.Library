using System;
using System.Collections.Generic;
using System.ComponentModel.Design;
using System.Text;

namespace HillerødSejlklub.Library
{
    public class UserRepository: IUserRepository
    {
        private static Dictionary<string, User> _userData = new Dictionary<string, User>(); // SortedDictionary til at gemme brugere med navn som nøgle og sortere dem alfabetisk

        // Metode til at hente og udskrive alle medlemmer
        public List<User> GetAll()
        {
            return _userData.Values.ToList();
        }

        //Denne metode tilføjer en bruger til dictionary
        public static User Add(User user)
        {
            try
            {
                _userData.Add(user.Name, user);
                return user;
            } catch(ArgumentException ex)
            {
                Console.WriteLine(ex.Message);
                return null;
            }
           
        } 
       

        //Denne metode henter en bruger baseret på navn
        public User GetByName(string userName)
        {
            return _userData[userName];
        }

        // Denne metode fjerner en bruger baseret på navn
        public User RemoveByName(string UserName)
        {
            User UserRemove = GetByName(UserName); // Tjekker om brugeren findes
            {
                try {
                    _userData.Remove(UserRemove.Name); // Fjerner brugeren fra Dictionary
                    Console.WriteLine("Medlem Fjernet:");
                    return UserRemove;
                } catch (ArgumentNullException ex)
                {
                    Console.WriteLine(ex.Message);
                }
                
            }
            return null;
        }

        // Denne metode henter en bruger baseret på ID
        private User GetById(int id)
        {

            foreach (User user in _userData.Values) // Gennemgår alle brugere i Dictionary
            {

                if (user.Id == id) // Tjekker om brugerens ID er det samme som det givne ID
                {
                    Console.WriteLine($"Fandt bruger: {user.Name}");
                    return user;
                }
            }

            return null;
        }

        // Denne metode opdaterer en brugers oplysninger baseret på ID
        public void Update(int id, string newAddress = null, string newPhone = null, string newEmail = null)
        {
            User userToEdit = GetById(id); // Henter brugeren baseret på ID

            if (userToEdit != null) // Tjekker om brugeren findes
            {

                if (newAddress != null) // Opdaterer adressen, hvis en ny adresse bliver skrevet ind
                {
                    userToEdit.Adress = newAddress; // Opdaterer adressen
                }

                if (newPhone != null) // opdaterer telefonnummeret, hvis et nyt nummer bliver skrevet ind
                {
                    userToEdit.Phone = newPhone; // Opdaterer telefonnummeret
                }

                if (newEmail != null) // Opdaterer emailen, hvis en ny email bliver skrevet ind
                {
                    userToEdit.Email = newEmail; // Opdaterer emailen
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
