using System;
using GameConsole.Base;
using GameConsole.Models;
namespace GameConsole.Pages;
public class DetailsScreen : Screen
{
    public DetailsScreen() : base("Details Screen")
    {
    }
    public override void Show()
    {
        base.Show();
        User currentUser = ConsoleGame.user;
        centerText("User Profile:");
        centerText($"Name: {currentUser.Name}");
        centerText($"Username: {currentUser.UserName}");
        
        centerText("Press any key to return to the main menu...");
        
        Console.ReadKey();
        Screen next = new MainMenu();
        next.Show();
    }
}