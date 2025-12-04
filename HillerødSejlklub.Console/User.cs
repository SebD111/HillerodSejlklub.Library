using System;
using System.Collections.Generic;
using System.Text;

namespace HillerødSejlklub.Console
{
    public class User
    
    {
        public class User
        {


            public User(int id, string name, string adress, string phone, string email)
            {
                Id = id;
                Name = name;
                Adress = adress;
                Phone = phone;
                Email = email;
            }

            public int Id { get; set; }

            public string Name { get; set; }

            public string Adress { get; set; }

            public string Phone { get; set; }

            public string Email { get; set; }

            public void GetAllMembers()
            {
                foreach (var user in _users)
                {
                    console.writeline($" Navn: {user.Name} -  ID: {user.Id} - Adresse: {user.Adress} - Telefon: {user.Phone} - Email: {user.Email}");
                }
            }

        }
    }

}

