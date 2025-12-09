using System;
using System.Collections.Generic;
using System.Text;

namespace HillerødSejlklub.Library
{
    public class UserRepository
    {
        private static SortedDictionary<string, User> _userData = new SortedDictionary<string, User>(); // SortedDictionary til at gemme brugere med navn som nøgle og sortere dem alfabetisk

        // Metode til at hente og udskrive alle medlemmer
        public void GetAllMembers()
        {
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("\nMedlemsliste i Hillerød Sejlklub");
            Console.ResetColor();
            Console.ForegroundColor= ConsoleColor.DarkGray;
            Console.WriteLine("-------------------------------------------");
            Console.ResetColor();

            foreach (var user in _userData.Values)
            {
                // Navn "fremhæves" i cyan farve
                Console.ForegroundColor = ConsoleColor.Cyan;
                Console.WriteLine($"{user.Name}");
                Console.ResetColor();

                // Strukur
                Console.WriteLine($"  ID: {user.Id}");
                Console.WriteLine($"  Adresse: {user.Adress}");
                Console.WriteLine($"  Telefon: {user.Phone}");
                Console.WriteLine($"  Email: {user.Email}");
                Console.WriteLine($"  Oprettet: {user.Time}");

                // Separator
                Console.ForegroundColor = ConsoleColor.DarkGray;
                Console.WriteLine("-------------------------------------------");
                Console.ResetColor();
            }
        }


        //Denne metode tilføjer en bruger til dictionary
        public static User AddUser(User user)
        {
            _userData.Add(user.Name, user);
            return user;
        }

        //Denne metode henter en bruger baseret på navn
        public User GetUsersByName(string userName)
        {
            foreach (User user in _userData.Values) // Gennemgår alle brugere i Dictionary
            {
                if (user.Name == userName) // Tjekker om brugerens navn matcher det givne navn
                {
                    return user;
                }
            }
            return null;
        }

        // Denne metode fjerner en bruger baseret på navn
        public User RemoveUserByName(string UserName)
        {
            User UserRemove = GetUsersByName(UserName); // Tjekker om brugeren findes

            if (UserRemove != null) // Hvis brugeren findes, fjernes den fra Dictionary
            {
                _userData.Remove(UserRemove.Name); // Fjerner brugeren fra Dictionary
                Console.WriteLine("Medlem Fjernet:");
                return UserRemove;
            }
            return null;
        }

        // Denne metode henter en bruger baseret på ID
        public User GetUserById(int id)
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
        public void UpdateUser(int id, string newAddress = null, string newPhone = null, string newEmail = null)
        {
            User userToEdit = GetUserById(id); // Henter brugeren baseret på ID

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
