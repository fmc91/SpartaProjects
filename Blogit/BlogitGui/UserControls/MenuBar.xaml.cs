using System;
using System.Collections.Generic;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Input;


namespace BlogitGui
{
    public partial class MenuBar : UserControl
    {
        public string Username
        {
            get { return (string)GetValue(UsernameProperty); }
            set { SetValue(UsernameProperty, value); }
        }

        public event RoutedEventHandler HomeButtonClick;

        public event RoutedEventHandler NewPostButtonClick;

        public event RoutedEventHandler MyPostsButtonClick;

        public event RoutedEventHandler ProfileButtonClick;

        public event RoutedEventHandler LogoutButtonClick;

        public MenuBar()
        {
            InitializeComponent();
        }
        public void OnHomeButtonClick(object sender, RoutedEventArgs e) => HomeButtonClick?.Invoke(this, new RoutedEventArgs());

        public void OnNewPostButtonClick(object sender, RoutedEventArgs e) => NewPostButtonClick?.Invoke(this, new RoutedEventArgs());

        public void OnMyPostsButtonClick(object sender, RoutedEventArgs e) => MyPostsButtonClick?.Invoke(this, new RoutedEventArgs());

        public void OnProfileButtonClick(object sender, RoutedEventArgs e) => ProfileButtonClick?.Invoke(this, new RoutedEventArgs());

        public void OnLogoutButtonClick(object sender, RoutedEventArgs e) => LogoutButtonClick?.Invoke(this, new RoutedEventArgs());


        public static readonly DependencyProperty UsernameProperty =
            DependencyProperty.Register(nameof(Username), typeof(string), typeof(MenuBar), new PropertyMetadata(String.Empty));
    }
}
