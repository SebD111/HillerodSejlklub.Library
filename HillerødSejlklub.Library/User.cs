using System;
using System.Collections.Generic;
using System.Text;

namespace HillerødSejlklub.Library
{
    
    public class User
    {
        public User(int id, string name, string adress, string phone, string email, bool admin)
        {
            Id = id;
            Name = name;
            Adress = adress;
            Phone = phone;
            Email = email;
            Admin = admin;
            UserRepository.AddUser(this);
        }

        public int Id { get; set; }

        public string Name { get; set; }

        public string Adress { get; set; }

        public string Phone { get; set; }

        public string Email { get; set; }
        public bool Admin { get; set; }
        
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
    




