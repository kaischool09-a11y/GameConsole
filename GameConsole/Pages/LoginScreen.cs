using GameConsole.Base;
using GameConsole.Data;
using GameConsole.Models;
using GameConsole.Pages;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace GameConsole.Pages
{
    public class LoginScreen : Screen
    {
        public LoginScreen() : base("Login screen")
        {

        }
        public override void Show()
        {
            base.Show();
            Console.WriteLine("login screen:");
            centerText(" enter details");
            User user = null;
            while (user == null)
            {
                Console.WriteLine("Enter Account Name: ");
                string name = Console.ReadLine();


                Console.WriteLine("Enter Account Password: ");
                string password = Console.ReadLine();

                user = UsedDb.login(name, password);

                if (user == null)
                {
                    Console.WriteLine(" login Failed.  invalid input.");
                    Console.WriteLine("Please try again");
                }
            }
            if (user != null)
            {
                Console.WriteLine("Login Completed");
                ConsoleGame.user = user;
                Console.ReadKey();

                ProfileScreen n = new ProfileScreen();
                n.Show();
            }
        }
        }
    }

