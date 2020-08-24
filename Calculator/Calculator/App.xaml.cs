using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Linq;
using System.Threading.Tasks;
using System.Windows;

namespace Calculator
{
    public partial class App : Application
    {
        public void AppStartup(object sender, StartupEventArgs e)
        {
            MainWindow appWindow = new MainWindow();

            CalculatorController controller = new CalculatorController(appWindow);

            appWindow.Show();
        }
    }
}
