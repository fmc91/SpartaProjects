using System;
using System.Collections.Generic;
using System.Windows;
using System.Windows.Controls;

namespace BlogitGui
{
    public partial class CreateBlogPage : Page
    {
        private Controller m_controller;

        public CreateBlogPage(CreateBlogViewModel viewModel, Controller controller)
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

        private void ConfirmButtonClick(object sender, RoutedEventArgs e)
        {
            CreateBlogViewModel viewModel = (CreateBlogViewModel)DataContext;

            if (ValidateAllInput())
                m_controller.CreateBlog(viewModel.UserActualName, viewModel.BlogName, viewModel.BlogCategory, viewModel.BlogAbout);
        }

        private void SkipButtonClick(object sender, RoutedEventArgs e)
        {
            m_controller.Home();
        }

        private bool ValidateAllInput()
        {
            CreateBlogViewModel viewModel = (CreateBlogViewModel)DataContext;

            if (String.IsNullOrWhiteSpace(viewModel.UserActualName))
            {
                MessageBox.Show("Please enter your name. You can enter a pseudonym if you don't want to use your real name.", "Name required");
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
                MessageBox.Show("Please fill in the about section by writing a description of your blog.", "Description required");
                return false;
            }

            return true;
        }
    }
}
