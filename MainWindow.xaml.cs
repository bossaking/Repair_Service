using System.Windows;

namespace Repair_Service
{
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();

            LoginPage loginPage = new LoginPage();
            MyFrame.NavigationService.Navigate(loginPage);
        }
    }
}
