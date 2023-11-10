using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace Task_6
{
    internal class User
    {
        public string Name { get; set; }
        public string Surname { get; set; }
        public string Username { get; set; }
        public string Password { get; set; }

        public User(string name, string surname, string username, string password)
        { 
            Name = name;
            Surname = surname;
            Username = username;
            Password = password;
        }


    }
}
