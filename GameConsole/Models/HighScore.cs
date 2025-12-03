using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameConsole.Models
{
    internal class HighScore
    {
        public int Score { get; set; }
        public string gameName { get; set; }

        public HighScore(int score, string gameName )
        {
            Score = score;
            this.gameName = gameName;
        }
    }
}
