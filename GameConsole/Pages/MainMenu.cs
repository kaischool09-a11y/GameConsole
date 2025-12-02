using GameConsole.Base;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameConsole.Pages
{
    internal class MainMenu : Base.MenuScreen
    {
        public MainMenu() : base("Main Menu")
        {
            Add(new MenuItem("register", new RegisterScreen()));
            Add(new MenuItem("Login", new LoginScreen()));
          
           /* Screen next = new LoginScreen();
            next.Show();
           */
        }
       
    }
}
