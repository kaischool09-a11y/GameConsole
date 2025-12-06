using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameConsole.Data
{
    internal class UsedDb
    {
        private static List<User> users;


        public static User RegisterUser(string name, string uName, string password)
        {

            User newUser = new User(name, uName, password);
            users.Add(newUser);
            return newUser;
        }
        public User login(string name, string password)
        {
            foreach (User user in users)
            {
                if (user.UserName == name && user.Password == password)
                {
                    return user;
                }

            }
            return null;
        }
        public static void Update(User u)
        {
            foreach (User user in users)
            { 
                if (user.UserName == u.UserName)
                {
                    user.Password = u.Password;

                }
                else
                {
                    throw new InvalidOperationException("no such user exists");
                }
            }
        }
    }
}
