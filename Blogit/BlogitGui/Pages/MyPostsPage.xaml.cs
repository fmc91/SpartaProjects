using System;
using System.Collections.Generic;
using System.Windows;
using System.Windows.Controls;

namespace BlogitGui
{
    public partial class MyPostsPage : Page
    {
        private Controller m_controller;

        public MyPostsPage(MyPostsViewModel viewModel, Controller controller)
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

        private void EditButtonClick(object sender, RoutedEventArgs e)
        {
            int postId = (int)((Button)sender).Tag;

            m_controller.EditPost(postId);
        }
    }
}
