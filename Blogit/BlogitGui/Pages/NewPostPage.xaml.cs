using System;
using System.Windows;
using System.Windows.Controls;


namespace BlogitGui
{
    public partial class NewPostPage : Page
    {
        Controller m_controller;

        public NewPostPage(NewPostViewModel viewModel, Controller controller)
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

        private void PostButtonClick(object sender, RoutedEventArgs e)
        {
            NewPostViewModel viewModel = (NewPostViewModel)DataContext;

            m_controller.Post(viewModel.Title, viewModel.Content);
        }
    }
}
