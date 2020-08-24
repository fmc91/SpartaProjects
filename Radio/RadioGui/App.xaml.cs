using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using System.Windows;

namespace Radio
{
    public partial class App : Application
    {
        private RadioPlayer m_player;
        private RadioViewModel m_viewModel;
        private MainWindow m_appWindow;

        public void AppStartup(object sender, StartupEventArgs e)
        {
            m_player = new RadioPlayer();
            m_viewModel = new RadioViewModel(m_player);
            m_appWindow = new MainWindow(m_viewModel);

            m_appWindow.Show();
        }
    }
}
