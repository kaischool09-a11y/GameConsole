using System;
using GameConsole.Base;
using GameConsole.Data;
using GameConsole.Models;
namespace GameConsole.Pages;
internal class UpdateScreen : Screen
{
    public UpdateScreen() : base("Update Screen")
    {
    }
    public override void Show()
    {
        base.Show();
        User currentUser = ConsoleGame.user;
        centerText("To Update Your Profile:");
        centerText("Enter new name:");
        string newName = Console.ReadLine();
        centerText("Enter new password:");
        string newPassword = Console.ReadLine();
        currentUser.Name = newName;
        currentUser.Password = newPassword;
        UsedDb.Update(currentUser);
        centerText("Profile updated successfully!");
        centerText("Press any key to return to the main menu...");
        Console.ReadKey();
        Screen next = new MainMenu();
        next.Show();
    }
}