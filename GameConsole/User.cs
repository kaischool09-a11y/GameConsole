using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameConsole
{
    
    internal class User
    {
        public string Name { get; set; }
        public string Username { get; set; }
        public int  Password { get; set; }

        public User(string name, string username, int password)
        {
            Name = name;
            Username = username;
            Password = password;
        }
    }
}
