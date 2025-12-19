using GameConsole.Base;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameConsole.Pages
{
    public class ActionMenu: MenuScreen
    {
        public ActionMenu(): base("Action Menu")
        {
            Add("View or Update User Details", new ProfileScreen());
            Add("Go to game menu", new GameMenuScreen());
            Add("view history details", new HistoryScreen());
            Add("Back to Main Menu", new MainMenu());

        }
    }
}
