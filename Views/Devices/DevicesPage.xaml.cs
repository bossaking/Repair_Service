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
    public partial class DevicesPage : Page
    {
        DevicesPageController pageController;
        MainWindow window;
        public DevicesPage()
        {
            InitializeComponent();
            pageController = new DevicesPageController();
        }

        private void Page_Loaded(object sender, RoutedEventArgs e)
        {
            window = (MainWindow)Application.Current.MainWindow;
            window.Title = "Repair Service: Devices";
            GetDevices();
        }

        private async void GetDevices()
        {
            DataGrid.ItemsSource = await pageController.GetDevicesAsync();
        }

        public async void RefreshData()
        {
            if (await pageController.RefreshDevices())
            {
                DataGrid.ItemsSource = await pageController.GetDevicesAsync();
                window.StopRefreshing();
            }
        }
        private async void DeleteDevice()
        {
            if (!await pageController.DeleteDeviceAsync(DataGrid.SelectedItem as Device))
            {
                //MessageBox.Show("Selected item cannot be deleted!", "Delete error", MessageBoxButton.OK, MessageBoxImage.Error);
                
                ErrorWindow errorWindow = new ErrorWindow
                {
                    Owner = window
                };

                errorWindow.text = "Selected item cannot be deleted!";
                errorWindow.ShowDialog();
            }
        }

        #region BUTTONS
        private void EditButton_Click(object sender, RoutedEventArgs e)
        {
            Device device = new Device
            {
                Id_Device = (DataGrid.SelectedItem as Device).Id_Device,
                Model_Title = (DataGrid.SelectedItem as Device).Model_Title,
                Device_Type = (DataGrid.SelectedItem as Device).Device_Type,
                Device_Brand = (DataGrid.SelectedItem as Device).Device_Brand,
                Orders = (DataGrid.SelectedItem as Device).Orders
            };
            AddDevicePage addEditDevicePage = new AddDevicePage(pageController, device, Modes.Edit);
            this.NavigationService.Navigate(addEditDevicePage);
        }

        private void DeleteButton_Click(object sender, RoutedEventArgs e)
        {
            //if (MessageBox.Show("Are you sure you want to remove the selected device?", "Delete device",
            //    MessageBoxButton.YesNo, MessageBoxImage.Question) != MessageBoxResult.Yes)
            //{
            //    return;
            //}
            //else
            //{
            //    DeleteDevice();
            //}

            DeleteWindow deleteWindow = new DeleteWindow
            {
                Owner = window
            };

            if (deleteWindow.ShowDialog() == true)
            {
                DeleteDevice();
            }
            else
            {
                return;
            }
        }

        private void AddButton_Click(object sender, RoutedEventArgs e)
        {
            AddDevicePage addEditDevicePage = new AddDevicePage(pageController, new Device(), Modes.Add);
            this.NavigationService.Navigate(addEditDevicePage);
        }

        private void BackButton_Click(object sender, RoutedEventArgs e)
        {
            MainPage mainPage = new MainPage();
            this.NavigationService.Navigate(mainPage);
        }
        #endregion
    }
}
