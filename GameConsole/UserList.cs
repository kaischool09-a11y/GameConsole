using GameConsole.Base;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameConsole
{
    internal class UserList
    {
       public List<User> users;
        public UserList(User user) {
        users=new List<User>();
        }
        public void registery(User user)
        {
            if (user != null && !users.Contains(user))
            {
                users.Add(user);
            }
        }
        public User login(string name, int password) {
            foreach (User user in users) {
                if (user.Username == name && user.Password==password)
                {
                    return user;
                }
           
            }
            return null;
        }
    }
}
