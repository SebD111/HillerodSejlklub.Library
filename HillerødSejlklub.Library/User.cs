using System;
using System.Collections.Generic;
using System.Text;

namespace HillerødSejlklub.Library
{
    
    public class User
    {
        private static int _id = 0;
        // Constructor der initialiserer en bruger og tilføjer den til UserRepository
        public User(string name, string adress, string phone, string email, bool admin)
        {
            _id++;
            Id = _id;
            Name = name;
            Adress = adress; 
            Phone = phone;
            Email = email;
            Admin = admin;
            Time = DateTime.Now;
        }
        // Properies
        public int Id {get;set;}
        public string Name { get; set; }

        public string Adress { get; set; }

        public string Phone { get; set; }

        public string Email { get; set; }
        public bool Admin { get; set; }

        public DateTime Time { get; set; }

        public void GetAll()
        {
            Overlay();
            UserRepository userRepository = new UserRepository();
            foreach (User user in userRepository.GetAll())
            {
                DisplayUserInfo(user);
            }
        }

        private void Overlay()
        {
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("\nMedlemsliste i Hillerød Sejlklub");
            Console.ResetColor();
            Console.ForegroundColor = ConsoleColor.DarkGray;
            Console.WriteLine("-------------------------------------------");
            Console.ResetColor();
        }

        private void DisplayUserInfo(User user)
        {
            // Navn "fremhæves" i cyan farve
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.WriteLine($"{Name}");
            Console.ResetColor();

            // Strukur
            Console.WriteLine($"  ID: {Id}");
            Console.WriteLine($"  Adresse: {Adress}");
            Console.WriteLine($"  Telefon: {Phone}");
            Console.WriteLine($"  Email: {Email}");
            Console.WriteLine($"  Oprettet: {Time}");

            // Separator
            Console.ForegroundColor = ConsoleColor.DarkGray;
            Console.WriteLine("-------------------------------------------");
            Console.ResetColor();
        }

    }

}
