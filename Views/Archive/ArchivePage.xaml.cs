using Repair_Service.Controllers;
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
    public partial class ArchivePage : Page
    {
        ArchivePageController pageController;
        MainWindow window;
        public ArchivePage()
        {
            InitializeComponent();
            this.Loaded += ArchivePage_Loaded;

            pageController = new ArchivePageController();
        }

        private void ArchivePage_Loaded(object sender, RoutedEventArgs e)
        {
            window = (MainWindow)Application.Current.MainWindow;
            window.Title = "Repair Service: Archive";
            LoadOrders();
        }

        private async void LoadOrders()
        {
            DataGrid.ItemsSource = await pageController.GetOrdersAsync();
        }

        public async void RefreshData()
        {
            if(await pageController.RefreshArchive())
            {
                DataGrid.ItemsSource = await pageController.GetOrdersAsync();
                window.StopRefreshing();
            }
        }

        private async void DeleteOrder()
        {
            await pageController.DeleteOrder((DataGrid.SelectedItem as Order).Id_Order);
        }

        private void BackButton_Click(object sender, RoutedEventArgs e)
        {
            MainPage mainPage = new MainPage();
            this.NavigationService.Navigate(mainPage);
        }

        private void DetailsButton_Click(object sender, RoutedEventArgs e)
        {
            ArchieveDetailsPage archieveDetailsPage = new ArchieveDetailsPage(DataGrid.SelectedItem as Order);
            this.NavigationService.Navigate(archieveDetailsPage);
        }

        private void RestoreButton_Click(object sender, RoutedEventArgs e)
        {
            pageController.RestoreOrder(DataGrid.SelectedItem as Order);
        }

        private void DeleteButton_Click(object sender, RoutedEventArgs e)
        {
            
            if (MessageBox.Show("Are you sure you want to remove the selected order?", "Delete order",
    MessageBoxButton.YesNo, MessageBoxImage.Question) != MessageBoxResult.Yes)
            {
                return;
            }
            else
            {
                DeleteOrder();
            }
        }
    }
}
