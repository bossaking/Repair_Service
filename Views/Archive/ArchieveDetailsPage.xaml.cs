using Repair_Service.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace Repair_Service
{
    public partial class ArchieveDetailsPage : Page
    {
        Order order;
        public ArchieveDetailsPage(Order order)
        {
            InitializeComponent();

            this.order = order;
        }

        private void ArchieveDetailsPage_Loaded(object sender, RoutedEventArgs e)
        {
            DataContext = order;
            ProblemsComboBox.ItemsSource = (System.Collections.IList)order.Problems;
            ProblemsComboBox.SelectedItems = (System.Collections.IList)order.Problems;
        }

        private void CancelButton_Click(object sender, RoutedEventArgs e)
        {
            ArchivePage archivePage = new ArchivePage();
            this.NavigationService.Navigate(archivePage);
        }

        private void Page_Loaded(object sender, RoutedEventArgs e)
        {
            MainWindow window = (MainWindow)Application.Current.MainWindow;
            window.Title = "Repair Service: Details in archive";
            ArchieveDetailsPage_Loaded(sender, e);
        }

        private void PrintButton_Click(object sender, RoutedEventArgs e)
        {
            PrintArchivedOrderWindow printArchivedOrderWindow = new PrintArchivedOrderWindow() { Owner = Window.GetWindow(this) };
            printArchivedOrderWindow.ShowDialog();
        }
    }
}
