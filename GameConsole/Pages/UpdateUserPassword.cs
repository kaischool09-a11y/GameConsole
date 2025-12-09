using System;
using GameConsole.Base;
using GameConsole.Data;
using GameConsole.Models;

namespace GameConsole.Pages
{
    internal class UpdateUserPassword: Screen
    {
        public UpdateUserPassword() : base("Update User Password")
        {
        }
        public override void Show()
        {
            base.Show();
            centerText("Enter your new password:");
            string newPassword = Console.ReadLine();
            ConsoleGame.user.Password = newPassword;
            centerText("Password updated successfully!");
            UsedDb.Update(ConsoleGame.user);
            centerText("Press any key to return to the main menu...");
            Console.ReadKey();
           
        }
    }
}
