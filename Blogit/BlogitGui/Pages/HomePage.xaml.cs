using System;
using System.Collections.Generic;
using System.Windows;
using System.Windows.Controls;

namespace BlogitGui
{
    public partial class HomePage : Page
    {
        private Controller m_controller;

        public HomePage(HomeViewModel viewModel, Controller controller)
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

        private void ViewBlogButtonClick(object sender, RoutedEventArgs e)
        {
            m_controller.ViewBlog((int)((Button)sender).Tag);
        }
    }
}
