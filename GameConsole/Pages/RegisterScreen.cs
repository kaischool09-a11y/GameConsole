using GameConsole.Base;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameConsole.Pages
{
    internal class RegisterScreen : Screen
    {
        private string UserName {  get; set; }
        private string Password { get; set; }
        public RegisterScreen() : base("Register screen")
        {
            base.Show();
            centerText("Enter details");

        }
    }
}
