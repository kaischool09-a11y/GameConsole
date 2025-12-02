using GameConsole.Base;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameConsole.Pages
{
    internal class WelcomeScreen: Screen
    {
        public WelcomeScreen(): base("Welcome") {
        
        }
        public override void Show()
        {
            base.Show();
          Console.WriteLine ("welcome to screen console");
            centerText("press any key to continue");
            Console.ReadKey();
            Screen next = new MainMenu();
            next.Show();

        }
    }
}
