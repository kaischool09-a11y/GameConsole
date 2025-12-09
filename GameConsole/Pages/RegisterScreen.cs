using GameConsole.Base;
using GameConsole.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace GameConsole.Pages
{
    internal class RegisterScreen : Screen
    {
        private string UserName {  get; set; }
        private string Name { get; set; }

        private string Password { get; set; }
        public RegisterScreen() : base("Register screen")
        {
            
            
        }
        public override void Show()
        {
            base.Show();
            string text = "Register Screen";
            User user=null;
            while (user == null)
            {
                Console.WriteLine("Enter Account Name: ");
                Name = Console.ReadLine();

                Console.WriteLine("Enter Account User: ");
                UserName = Console.ReadLine();

                Console.WriteLine("Enter Account Password: ");
                Password = Console.ReadLine();

                user = UsedDb.RegisterUser(Name, UserName, Password);

                if (user == null)
                {
                    Console.WriteLine(" Registration Failed. Username already exists or invalid input.");
                    Console.WriteLine("Please try again");
                }
            }
            Console.WriteLine("Registration Completed");
            Console.ReadKey();
        }
    }
}
