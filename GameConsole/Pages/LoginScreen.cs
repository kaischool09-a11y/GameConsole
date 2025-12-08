using GameConsole.Base;
using GameConsole.Data;
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
                    Console.WriteLine(" Registration Failed. Username already exists or invalid input.");
                    Console.WriteLine("Please try again");
                }
            }
            Console.WriteLine("Registration Completed");
            Console.ReadKey();

            GameMenuScreen n = new GameMenuScreen();
            n.Show();
        }
        }
    }

