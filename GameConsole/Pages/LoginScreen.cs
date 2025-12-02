using GameConsole.Base;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameConsole.Pages
{
    internal class LoginScreen : Screen
    {
        public LoginScreen() : base("Login screen")
        {

        }
        public override void Show()
        {
            base.Show();
            centerText("enter details");
            Console.ReadKey();
        }
    }
}
