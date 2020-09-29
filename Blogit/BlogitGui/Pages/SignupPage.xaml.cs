using System;
using System.Collections.Generic;
using System.Windows;
using System.Windows.Controls;


namespace BlogitGui
{
    public partial class SignupPage : Page
    {
        private Controller m_controller;

        public SignupPage(SignupViewModel viewModel, Controller controller)
        {
            DataContext = viewModel;

            m_controller = controller;

            InitializeComponent();
        }

        private void PasswordBoxLostFocus(object sender, RoutedEventArgs e)
        {
            if (PasswordBox.Password.Length < 6)
                ((SignupViewModel)DataContext).PasswordTooShort = true;
            else
                ((SignupViewModel)DataContext).PasswordTooShort = false;

            if (String.IsNullOrEmpty(ConfirmPasswordBox.Password)) return;

            if (PasswordBox.Password == ConfirmPasswordBox.Password)
                ((SignupViewModel)DataContext).PasswordsDontMatch = false;

            else
                ((SignupViewModel)DataContext).PasswordsDontMatch = true;
        }

        private void ConfirmPasswordBoxLostFocus(object sender, RoutedEventArgs e)
        {
            if (PasswordBox.Password == ConfirmPasswordBox.Password)
                ((SignupViewModel)DataContext).PasswordsDontMatch = false;

            else
                ((SignupViewModel)DataContext).PasswordsDontMatch = true;
        }

        private void SignupButtonClick(object sender, RoutedEventArgs e)
        {
            SignupViewModel viewModel = (SignupViewModel)DataContext;

            if (ValidateAllInput())
                m_controller.Signup(viewModel.Username, PasswordBox.Password, viewModel.EmailAddress);
        }

        private void CancelButtonClick(object sender, RoutedEventArgs e)
        {
            m_controller.LoginPage();
        }

        private bool ValidateAllInput()
        {
            SignupViewModel viewModel = (SignupViewModel)DataContext;

            if (String.IsNullOrEmpty(viewModel.Username))
            {
                MessageBox.Show("Please enter a username", "Username required");
                return false;
            }

            if (String.IsNullOrEmpty(PasswordBox.Password))
            {
                MessageBox.Show("Please enter a password", "Password required");
                return false;
            }

            if (String.IsNullOrEmpty(ConfirmPasswordBox.Password))
            {
                MessageBox.Show("Please confirm your password", "Password confirmation required");
                return false;
            }

            if (String.IsNullOrEmpty(viewModel.EmailAddress))
            {
                MessageBox.Show("Please enter an email address", "Email address required");
                return false;
            }

            if (Validation.GetHasError(UsernameBox) || Validation.GetHasError(EmailBox) || viewModel.PasswordTooShort || viewModel.PasswordsDontMatch)
            {
                MessageBox.Show("Please enter valid information", "Invalid information");
                return false;
            }

            return true;
        }
    }
}
