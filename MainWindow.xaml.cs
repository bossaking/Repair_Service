using System.Windows;

namespace Repair_Service
{
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();

            MyFrame.NavigationService.Navigate(new LoginPage());
        }

        private void RefreshButton_Click(object sender, RoutedEventArgs e)
        {

        }
    }
}
