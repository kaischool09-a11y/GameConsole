using GameConsole.Base;
using GameConsole.Games;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameConsole.Pages
{
    public class DetailsMenu:MenuScreen
    {
        public DetailsMenu (): base("User Details Menu")
        {
           FluffyBirdGame fluffy = new FluffyBirdGame();
            Add(new MenuItem("Fluffy Bird", new GameScreen(fluffy)));
            PacManGame pacManGame = new PacManGame();
            Add(new MenuItem("Pac Man", new GameScreen(pacManGame)));
        }
        public override void Show()
        {
            base.Show();
        }
    }

    }

