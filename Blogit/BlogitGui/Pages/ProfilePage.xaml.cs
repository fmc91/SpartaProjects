using System;
using System.Collections.Generic;
using System.Windows;
using System.Windows.Controls;

namespace BlogitGui
{
    public partial class ProfilePage : Page
    {
        private Controller m_controller;

        public ProfilePage(ProfileViewModel viewModel, Controller controller)
        {
            DataContext = viewModel;

            m_controller = controller;

            InitializeComponent();
        }

        private void HomeButtonClick(object sender, RoutedEventArgs e) => m_controller.Home();
        private void NewPostButtonClick(object sender, RoutedEventArgs e) => m_controller.NewPost();
        private void MyPostsButtonClick(object sender, RoutedEventArgs e) => m_controller.MyPosts();
        private void ProfileButtonClick(object sender, RoutedEventArgs e) => m_controller.Profile();
        private void LogoutButtonClick(object sender, RoutedEventArgs e) => m_controller.Logout();

        private void SaveChangesButtonClick(object sender, RoutedEventArgs e)
        {
            if (ValidateAllInput())
            {
                ProfileViewModel viewModel = (ProfileViewModel)DataContext;

                m_controller.SaveChangesToProfile(viewModel.EmailAddress, viewModel.Name, viewModel.BlogName, viewModel.BlogCategory, viewModel.BlogAbout);

                MessageBox.Show("Your changes have been saved.", "Chanegs saved");
            }
        }

        private void CancelButtonClick(object sender, RoutedEventArgs e)
        {
            m_controller.Home();
        }

        private bool ValidateAllInput()
        {
            ProfileViewModel viewModel = (ProfileViewModel)DataContext;

            if (String.IsNullOrWhiteSpace(viewModel.EmailAddress))
            {
                MessageBox.Show("Please enter an email address.", "Email address required");
                return false;
            }

            if (String.IsNullOrWhiteSpace(viewModel.Name))
            {
                MessageBox.Show("Please enter a name. You can use a pseudonym if you don't want to use your real name.", "Name required");
                return false;
            }

            if (String.IsNullOrWhiteSpace(viewModel.BlogName))
            {
                MessageBox.Show("Please enter a name for your blog.", "Blog name required");
                return false;
            }

            if (String.IsNullOrWhiteSpace(viewModel.BlogCategory))
            {
                MessageBox.Show("Please enter a category for your blog.", "Category required");
                return false;
            }

            if (String.IsNullOrWhiteSpace(viewModel.BlogAbout))
            {
                MessageBox.Show("Please enter a description of your blog in the about section.", "Description required");
                return false;
            }

            if (Validation.GetHasError(EmailBox))
            {
                MessageBox.Show("Please enter a valid email address.", "Invalid email address");
                return false;
            }

            return true;
        }
    }
}
