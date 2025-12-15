using System;
using System.Collections.Generic;
using System.Text;

namespace HillerødSejlklub.Library
{
    public class User
    {
        // instance field
        private static int _idCounter = 0;

        // Constructor 
        public User(string name, string adress, string phone, string email, bool admin)
        {
            _idCounter++;
            Id = _idCounter;
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
    }
}
