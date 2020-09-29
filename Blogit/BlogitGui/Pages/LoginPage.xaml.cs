using System;
using System.Collections.Generic;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Input;

namespace BlogitGui
{
    public partial class LoginPage : Page
    {
        private Controller m_controller;

        public LoginPage(LoginViewModel viewModel, Controller controller)
        {
            DataContext = viewModel;

            m_controller = controller;

            InitializeComponent();
        }

        private void LoginButtonClick(object sender, RoutedEventArgs e) => m_controller.Login(UsernameBox.Text, PasswordBox.Password);

        private void PasswordBoxPreviewKeyDown(object sender, KeyEventArgs e)
        {
            if (e.Key == Key.Enter)
                m_controller.Login(UsernameBox.Text, PasswordBox.Password);
        }

        private void SignupButtonClick(object sender, RoutedEventArgs e) => m_controller.SignupPage();
    }
}
