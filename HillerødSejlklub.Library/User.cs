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
            UserRepository.AddU(this); // Tilføjer instansen til UserRepository
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

        // Metoden der tjekker om brugeren er admin og henter alle både
        public void GetAllBoat(BoatRepository boatList, User user)
        {
            if (user.Admin == true) // Tjekker om brugeren er admin
            {
                var boats = BoatRepository.GetAll(); // Henter alle både
                foreach (var boat in boats)
                {
                    Console.WriteLine(boat); // Udskriv båd info (tilpas evt. udskrivning)
                }
            }
            else
            {
                Console.WriteLine("Du har ikke adgang til dette");
            }
        }
        // Metoden der tjekker om brugeren er admin og henter alle brugere
        public void GetAllUser(UserRepository userList,User user)
        {
            if (user.Admin == true) // Tjekker om brugeren er admin
            {
                userList.GetAll(); //Printer alle brugere
            }
            else 
            {
                Console.WriteLine("Du har ikke adgang til dette");
            }
        }
    }

}
