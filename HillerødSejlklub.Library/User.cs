using System;
using System.Collections.Generic;
using System.Text;

namespace HillerødSejlklub.Library
{
    
    public class User
    {
        private static int _id = 0;
        public User(string name, string adress, string phone, string email, bool admin)
        {
            _id++;
            Id = _id;
            Name = name;
            Adress = adress;
            Phone = phone;
            Email = email;
            Admin = admin;
            UserRepository.AddUser(this);
            Time = DateTime.Now;
        }
        public int Id {get;set;}
        public string Name { get; set; }

        public string Adress { get; set; }

        public string Phone { get; set; }

        public string Email { get; set; }
        public bool Admin { get; set; }

        public DateTime Time { get; set; }

        public void GetAllBoat(BoatRepository boatList,User user)
        {
            if (user.Admin == true)
            {
                boatList.PrintAllBoats();
            }
            else
            {
                Console.WriteLine("Du har ikke adgang til dette");
            }

        }
        public void GetAlleUser(UserRepository userList,User user)
        {
            if (user.Admin == true) 
            {
                userList.GetAllMembers();
            }
            else 
            {
                Console.WriteLine("Du har ikke adgang til dette");
            }
        }
    }

}
    




