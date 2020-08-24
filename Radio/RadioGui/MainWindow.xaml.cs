using System.Windows;


namespace Radio
{
    public partial class MainWindow : Window
    {
        public MainWindow(RadioViewModel viewModel)
        {
            DataContext = viewModel;

            InitializeComponent();
        }
    }
}
