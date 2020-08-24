using System;
using System.ComponentModel;
using System.Runtime.CompilerServices;
using System.Windows;
using System.Windows.Controls;

namespace Radio
{
    public partial class OnOffLight : UserControl
    {
        public bool IsOn
        {
            get { return (bool)GetValue(IsOnProperty); }
            set { SetValue(IsOnProperty, value); }
        }

        public static readonly DependencyProperty IsOnProperty =
            DependencyProperty.Register("IsOn", typeof(bool), typeof(OnOffLight), new PropertyMetadata(false));
        
        public OnOffLight()
        {
            InitializeComponent();
        }
    }
}
