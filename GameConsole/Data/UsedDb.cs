using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameConsole.Data
{
    internal class UsedDb
    {
        private static List<User> users=new List<User>();

                public static User RegisterUser(string name, string uName, string password)
        {

            User user = users.FirstOrDefault(u => u.UserName == uName);

            //foreach (User user in users)
            //{
            //    if (user.UserName == uName)
            //    {
            //        return null; // Username already exists
            //    }
            //}
            if (user != null)
            {
                return null; // Username already exists
            }
            User newUser = new User(name, uName, password);
            users.Add(newUser);
            return newUser;
        }
        public User login(string name, string password)
        {
            User user = users.FirstOrDefault(u => u.UserName == name);

            //foreach (User user in users)
            //{
            //    if (user.UserName == name && user.Password == password)
            //    {
            //        return user;
            //    }

            //}
            if (user != null)   
            {
                return user; // Username already exists
            }
            else {
                Console.WriteLine("no such user exists");

                return null;

            }
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
