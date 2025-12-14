using GameConsole.Base;
using GameConsole.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameConsole.Pages
{
    public class HistoryScreen : Screen
    {
        public HistoryScreen() : base("history screen")
        {



        }
        public override void Show()
        {
            base.Show();
            Console.WriteLine("choose display");
            centerText("1- Last Game Played");
            centerText("2- Order by Date");
            centerText("3- Order by Game Name");
            centerText("4-Order by Score");
            centerText("5- Exit");
            int choice = 0;
            while (choice < 1 || choice > 5)
            {
                centerText("Enter choice between 1-5:");
                int.TryParse(Console.ReadLine(), out choice);
            }
            if (choice == 1)
            {
                lastGamePlayed();
            }
            else if (choice == 2)
            {
                orderByDate();
            }
            else if (choice == 3)
            {
                orderByName();
            }
            else if (choice == 4)
            {
                orderByScore();
            }
            else if (choice == 5)
            {
                ProfileScreen profileScreen = new ProfileScreen();
                profileScreen.Show();
            }



        }
        public static void orderByScore()
        {
            List<HighScore> scores = ConsoleGame.user.Scores.OrderByDescending(s => s.Score).ToList();
            Console.WriteLine("Scores ordered by score:");
            foreach (HighScore score in scores)
            {
                Console.WriteLine($" Score:  {score.Score}\n Date:  {score.dates}");
            }
        }
        public static void lastGamePlayed()
        {
            List<HighScore> scores = ConsoleGame.user.Scores.OrderByDescending(s => s.dates).ToList();
            HighScore lastGame = scores[0];
            Console.WriteLine($" Last Game Played:  {lastGame.gameName}\n Score:  {lastGame.Score}\n Date:  {lastGame.dates}");


        }
        public static void orderByDate()
        {
            List<HighScore> scores = ConsoleGame.user.Scores.OrderByDescending(s => s.dates).ToList();
            Console.WriteLine("Scores ordered by date:");
            foreach (HighScore score in scores)
            {
                Console.WriteLine($" Date:  {score.dates}\n Score:  {score.Score}");

            }

        }
        public static void orderByName()
        {
            List<HighScore> scores = ConsoleGame.user.Scores.OrderBy(s => s.gameName).ToList();
            Console.WriteLine("Scores ordered by Game Name:");
            foreach (HighScore score in scores)
            {
                Console.WriteLine($" Game Name:  {score.gameName}\n Score:  {score.Score}");
            }
        }
    }
}
