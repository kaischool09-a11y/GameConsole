using GameConsole.Base;
using GameConsole.Models;
using GameConsole.Pages;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameConsole
{
    internal class ConsoleGame
    {
        public static User user;
        private Screen mainPage;
        public ConsoleGame()
        {
            mainPage = new WelcomeScreen();
        }

        public void startApp(){
            mainPage.Show();

        }
    }
}
