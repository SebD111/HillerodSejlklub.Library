using System;
using System.Collections.Generic;
using System.ComponentModel.Design;
using System.Numerics;
using System.Text;
using System.Xml.Linq;

namespace HillerødSejlklub.Library
{
    public class UserRepository : IUserRepository
    {
        // Instance field
        private static Dictionary<string, User> _userData = new Dictionary<string, User>() // SortedDictionary til at gemme brugere med navn som nøgle og sortere dem alfabetisk
        {
            { "Bob", new User("Bob","enellerandenvej 2, Rungsted","12345678", "Bob@mail.dk",true)},
            { "Dmitris", new User("Dmitris","enellerandenvej 3, Rungsted","23456789", "Dmitris@mail.dk",false)},
            { "Victor The Goat", new User("Victor The Goat","enellerandenvej 8, Rungsted","34567890", "VictorTheGoat@mail.dk",false)},
        };

        // Metode til at hente alle brugere som en liste
        public List<User> GetAll()
        {
            return _userData.Values.ToList();
        }

        // Denne metode tilføjer en bruger til dictionary
        public void Add(User user)
        {
            try 
            {
                _userData.Add(user.Name, user);

            } catch(ArgumentException ex) // Håndterer tilfælde hvor brugeren allerede findes
            {
                Console.WriteLine(ex.Message);
            }
        }

        // Denne metode henter en bruger baseret på navn
        public User GetByName(string userName)
        {
            try
            {
                return _userData[userName];
            }
            catch (KeyNotFoundException ex) // Håndterer tilfælde hvor brugeren ikke findes
            {
                throw new ArgumentNullException($"Bruger med navn '{userName}' blev ikke fundet.");
            }
        }

        // Denne metode fjerner en bruger baseret på navn
        public void RemoveByName(string userName)
        {
            {
                try {
                    _userData.Remove(userName); 
                    Console.WriteLine($"Medlem Fjernet: {userName}");

                } catch (ArgumentNullException ex) // Håndterer tilfælde hvor brugeren ikke findes
                {
                    Console.WriteLine(ex.Message);
                }
            }
        }

        // Denne metode henter en bruger baseret på ID
        public User GetById(int id)
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

        // Denne metode opdaterer en brugers informationer baseret på ID
        public void Update(int id, string newAddress = null, string newPhone = null, string newEmail = null)
        {
            User userToEdit = GetById(id); // Henter brugeren baseret på ID

            if (userToEdit != null) // Tjekker om brugeren findes
            {

                if (newAddress != null) // Opdaterer adressen, hvis en ny adresse bliver skrevet ind
                {
                    userToEdit.Adress = newAddress; 
                }

                if (newPhone != null) // opdaterer telefonnummeret, hvis et nyt nummer bliver skrevet ind
                {
                    userToEdit.Phone = newPhone; 
                }

                if (newEmail != null) // Opdaterer emailen, hvis en ny email bliver skrevet ind
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

        // Denne metode udskriver alle brugere i dictionary
        public void PrintAll()
        {
            Overlay();
            UserRepository userRepository = new UserRepository();
            foreach (User user in userRepository.GetAll())
            {
                Print(user);
            }
        }

        // Overlay til brugerlisten
        private void Overlay()
        {
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("\nMedlemsliste i Hillerød Sejlklub");
            Console.ResetColor();
            Console.ForegroundColor = ConsoleColor.DarkGray;
            Console.WriteLine("-------------------------------------------");
            Console.ResetColor();
        }


        // Print metode til en enkelt bruger
        private void Print(User user)
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

        // Denne metode tæller antal brugere i dictionary
        public int Count()
        { 
            return _userData.Count;
        }

    }
}
