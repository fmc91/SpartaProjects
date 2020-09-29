using System;
using System.Collections.Generic;
using System.Windows;
using System.Windows.Controls;


namespace BlogitGui
{
    public partial class EditPostPage : Page
    {
        private Controller m_controller;

        public EditPostPage(EditPostViewModel viewModel, Controller controller)
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
            EditPostViewModel viewModel = (EditPostViewModel)DataContext;

            m_controller.SaveChangesToPost(viewModel.PostId, viewModel.Title, viewModel.Content); 
        }

        private void CancelButtonClick(object sender, RoutedEventArgs e)
        {
            MessageBoxResult result = MessageBox.Show("All changes will be lost. Are you sure you want to proceed?", "Are you sure?", MessageBoxButton.YesNo);

            if (result == MessageBoxResult.Yes)
                m_controller.MyPosts();
        }

        private void DeleteButtonClick(object sender, RoutedEventArgs e)
        {
            MessageBoxResult result = MessageBox.Show("Post cannot be recovered once it is deleted. Are you sure you want to proceed?",
                                                      "Are you sure?", MessageBoxButton.YesNo);

            if (result == MessageBoxResult.Yes)
            {
                EditPostViewModel viewModel = (EditPostViewModel)DataContext;

                m_controller.DeletePost(viewModel.PostId);
            }
        }
    }
}
