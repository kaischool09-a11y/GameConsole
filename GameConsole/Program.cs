using GameConsole.Base;
using GameConsole.Interfaces;
using GameConsole.Models;
using GameConsole.Pages;

namespace GameConsole
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /* List<IGamePlay> games = new List<IGamePlay>();
             games.Add(new Games.TetrisGame());
             games.Add(new Games.FluffyBirdGame());
             games.Add(new Games.PacManGame());

             foreach (var game in games)
             {
                 game.Play();
                 Console.Write($" Game:{game.Name}");
                 Console.WriteLine($"Score:{game.Score}");
             }
            */
            // Screen mainScreen = new Screen("Home page");
            //  mainScreen.Show();
            Screen s = new Base.Screen("home page");

            List<User> users = new List<User>();
            User u1 = new User("john", "john123", "pass123");
            users.Add(u1);
            User u2 = new User("alice", "alice2", "word456");
            users.Add(u2);
            //s.Show();
            ConsoleGame game = new ConsoleGame();
            game.startApp();
        }
    }
}
