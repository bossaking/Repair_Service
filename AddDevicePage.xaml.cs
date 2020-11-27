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
    public partial class AddDevicePage : Page
    {
        //TODO Dodać sprawdzenie czy wszystkie pola są wypełnione
        DevicesPageController pageController;
        Device newDevice;
        public AddDevicePage(DevicesPageController pageController)
        {
            InitializeComponent();
            this.pageController = pageController;
        }

        private void Page_Loaded(object sender, RoutedEventArgs e)
        {
            newDevice = new Device();
            DataContext = newDevice;
            LoadData();
        }

        private async void LoadData()
        {
            TypesComboBox.ItemsSource = await pageController.GetTypesAsync();
            BrandsComboBox.ItemsSource = await pageController.GetBrandsAsync();
        }

        private async void AddNewDevice()
        {
            newDevice.Device_Type = TypesComboBox.SelectedItem as Device_Type;
            newDevice.Device_Brand = BrandsComboBox.SelectedItem as Brand;
            if(!await pageController.AddNewDevice(newDevice))
            {
                //TODO Zmienić komunikat
                MessageBox.Show("Jakiś tam error", "Error", MessageBoxButton.OK, MessageBoxImage.Error);
                return;
            }
            LoadDevicesPage();
        }

        #region BUTTONS
        private void OkButton_Click(object sender, RoutedEventArgs e)
        {
            AddNewDevice();
        }

        private void CancelButton_Click(object sender, RoutedEventArgs e)
        {
            LoadDevicesPage();
        }

        private void LoadDevicesPage()
        {
            DevicesPage devicesPage = new DevicesPage();
            this.NavigationService.Navigate(devicesPage);
        }
        #endregion


    }
}
