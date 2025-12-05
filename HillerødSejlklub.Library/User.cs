using System;
using System.Collections.Generic;
using System.Text;

namespace HillerødSejlklub.Library
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
       
            }

        }
    




