using Repair_Service.DAL;
using System.ComponentModel;
using System.Threading;
using System.Threading.Tasks;
using System.Windows;

namespace Repair_Service
{
    public partial class MainWindow : Window
    { 
        string pageName;
        public MainWindow()
        {
            InitializeComponent();
            MyFrame.NavigationService.Navigate(new LoginPage());
            
        }

        private void RefreshButton_Click(object sender, RoutedEventArgs e)
        {
            StartRefreshing();
            RefreshData();
        }


        private void RefreshData()
        {
            switch (pageName)
            {
                case "ClientsPage":
                    (MyFrame.Content as ClientsPage).RefreshData();
                    break;
                case "BrandsPage":
                    (MyFrame.Content as BrandsPage).RefreshData();
                    break;
                case "ArchivePage":
                    (MyFrame.Content as ArchivePage).RefreshData();
                    break;
                case "DevicesPage":
                    (MyFrame.Content as DevicesPage).RefreshData();
                    break;
                case "MainPage":
                    (MyFrame.Content as MainPage).RefreshData();
                    break;
                case "ProblemsPage":
                    (MyFrame.Content as ProblemsPage).RefreshData();
                    break;
                case "EmployeesPage":
                    (MyFrame.Content as EmployeesPage).RefreshData();
                    break;
                case "RolesPage":
                    (MyFrame.Content as RolesPage).RefreshData();
                    break;
                case "SalonsPage":
                    (MyFrame.Content as SalonsPage).RefreshData();
                    break;
                case "StatusesPage":
                    (MyFrame.Content as StatusesPage).RefreshData();
                    break;
                case "TypesPage":
                    (MyFrame.Content as TypesPage).RefreshData();
                    break;
                default:
                    StopRefreshing();
                    break;
            }
        }

        private void MyFrame_Navigated(object sender, System.Windows.Navigation.NavigationEventArgs e)
        {
            pageName = MyFrame.Content.GetType().Name;
            if (MyFrame.Content.GetType().Equals(typeof(LoginPage)))
            {
                MainWindowBorder.Visibility = Visibility.Hidden;
            }
            else
            {
                MainWindowBorder.Visibility = Visibility.Visible;
                HideProgressBar();
            }
        }

        public void ShowProgressBar()
        {
            ProgressBar.Visibility = Visibility.Visible;
        }

        public void HideProgressBar()
        {
            ProgressBar.Visibility = Visibility.Hidden;
        }

        public void StartRefreshing()
        {
            RefreshTextBlock.Text = "Status: REFRESHING";
            ShowProgressBar();
            RefreshButton.IsEnabled = false;
        }

        public void StopRefreshing()
        {
            RefreshTextBlock.Text = "Status: OK";
            HideProgressBar();
            RefreshButton.IsEnabled = true;
        }
    }
}
