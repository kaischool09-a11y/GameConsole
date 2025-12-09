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
        private DateTime dates;
        private string name;
        internal int score;

        public HighScore(int score, string gameName )
        {
         
            Score = score;
            this.gameName = gameName;
            this.dates = DateTime.Now;

        }

        public HighScore(string name, int score)
        {
            this.name = name;
            Score = score;
        }
    }
}
