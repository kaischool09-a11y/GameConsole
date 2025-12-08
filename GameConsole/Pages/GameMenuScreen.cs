using GameConsole.Base;
using GameConsole.Games;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameConsole.Pages
{
    public class GameMenuScreen : Base.MenuScreen
    {
        public GameMenuScreen(): base("game list"){
            Add("Fluffy", new GameScreen(new FluffyBirdGame()));
            Add("Pacman", new GameScreen(new PacManGame()));
            Add("tedris", new GameScreen(new TetrisGame()));
        
        }
        public override void Show()
        {
            base.Show();
        }

    }
}
