using System;
using System.Collections.Generic;
using System.Windows;
using System.Windows.Navigation;
using BlogitCrud;

namespace BlogitGui
{
    public partial class App : Application
    {
        public void AppStartup(object sender, StartupEventArgs e)
        {
            NavigationWindow mainWindow = new NavigationWindow
            {
                Width = 1000,
                Height = 800,
                MinWidth = 500,
                MinHeight = 400,
                ShowsNavigationUI = false
            };

            mainWindow.Navigated += (s, e) => mainWindow.NavigationService.RemoveBackEntry();

            Controller controller = new Controller(mainWindow, new CrudManager());

            mainWindow.Show();

            controller.LoginPage();
        }
    }
}
