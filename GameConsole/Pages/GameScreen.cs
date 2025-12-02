using GameConsole.Base;
using GameConsole.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameConsole.Pages
{
    internal class GameScreen:Screen
    {
        private IGamePlay game;

        public GameScreen(IGamePlay game): base(game.Name) 
        {
            this.game = game;
        }

        public override void Show()
        {
            base.Show();
            centerText("press anything to continue");
            Console.ReadKey();
            game.Play();
                
        }
        
    }
}
