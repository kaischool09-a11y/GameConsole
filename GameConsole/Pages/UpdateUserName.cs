using System;
using GameConsole.Base;
using GameConsole.Data;
using GameConsole.Models;


namespace GameConsole.Pages
{
    internal class UpdateUserName:Screen
    {
        public UpdateUserName() : base("Update User Name")
        {
        }
        public override void Show()
        {
            base.Show();
            centerText("Enter your new user name:");
            string newUserName = Console.ReadLine();
            ConsoleGame.user.Name = newUserName;
            UsedDb.Update(ConsoleGame.user);
            centerText("User name updated successfully!");
            centerText("Press any key to return to the main menu...");
            Console.ReadKey();
            Screen next = new MainMenu();
            next.Show();
        }
    }
}
