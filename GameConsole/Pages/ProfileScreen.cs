using System;
using GameConsole.Base;
using GameConsole.Data;
using GameConsole.Models;
namespace GameConsole.Pages;
internal class ProfileScreen : MenuScreen
{
    public ProfileScreen() : base("Profile Screen")
    {
        Add("View Details", new DetailsScreen());
        Add("Update UserName and Password Details", new UpdateScreen());
        Add("Update Password Only", new UpdateUserPassword());
        Add("Update Name only", new UpdateUserName());
        Add("Back to Main Menu", new MainMenu());
    }
}