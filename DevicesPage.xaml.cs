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
    //TODO Dodać edycje
    //TODO Dodać Progress Bar
    public partial class DevicesPage : Page
    {
        DevicesPageController pageController;
        public DevicesPage()
        {
            InitializeComponent();
            pageController = new DevicesPageController();
        }

        private void Page_Loaded(object sender, RoutedEventArgs e)
        {
            GetDevices();
        }

        private async void GetDevices()
        {
            DataGrid.ItemsSource = await pageController.GetDevicesAsync();
        }

        private async void DeleteDevice()
        {
            if(!await pageController.DeleteDeviceAsync(DataGrid.SelectedItem as Device))
            {
                //TODO Zmienić komunikat
                MessageBox.Show("Jakiś tam error", "Error", MessageBoxButton.OK, MessageBoxImage.Error);
            }
        }

        #region BUTTONS
        private void EditButton_Click(object sender, RoutedEventArgs e)
        {
            LoadAddEditDevicePage();
        }

        private void DeleteButton_Click(object sender, RoutedEventArgs e)
        {
            if (MessageBox.Show("Czy na pewno chcesz usunąć wybrany element?", "Usuń element",
                MessageBoxButton.YesNo, MessageBoxImage.Question) != MessageBoxResult.Yes)
            {
                return;
            }
            else
            {
                DeleteDevice();
            }
        }

        private void AddButton_Click(object sender, RoutedEventArgs e)
        {
            LoadAddEditDevicePage();
        }

        private void BackButton_Click(object sender, RoutedEventArgs e)
        {
            MainPage mainPage = new MainPage();
            this.NavigationService.Navigate(mainPage);
        }

        private void LoadAddEditDevicePage()
        {
            AddDevicePage addEditDevicePage = new AddDevicePage(pageController);
            this.NavigationService.Navigate(addEditDevicePage);
        }
        #endregion


    }
}
