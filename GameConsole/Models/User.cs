using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameConsole.Models
{
    
    internal class User
    {
        public string Name { get; set; }
        // public string Username { get; set; }
        public string  Password { get; set; }
        public string UserName { get; internal set; }
        public HighScore MaxScore { get; set; }
        public List<HighScore> Scores;



        public User(string name, string username, string password)
        {

            Name = name;
            UserName = username;
            Password = password;
            Scores = new List<HighScore>();
        }
    }
}
