using GameConsole.Base;
using GameConsole.Interfaces;
using GameConsole.Models;
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
            HighScore score = new HighScore(game.Name, game.Score);
            
            if (ConsoleGame.user.MaxScore!=null&& score.Score > ConsoleGame.user.MaxScore.score )
            {
                ConsoleGame.user.MaxScore = score;
            }
            else if (ConsoleGame.user.MaxScore == null)
            {
                ConsoleGame.user.MaxScore = score;
            }
            ConsoleGame.user.Scores.Add(score);
        }

    }
}
