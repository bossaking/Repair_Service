using Repair_Service.Controllers;
using Repair_Service.Models;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
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
        DevicesPageController pageController;
        Device device;
        Modes mode;
        MainWindow window;
        public AddDevicePage(DevicesPageController pageController, Device device, Modes mode)
        {
            InitializeComponent();
            this.pageController = pageController;
            this.device = device;
            this.mode = mode;

            window = (MainWindow)Application.Current.MainWindow;

            DataContext = device;
        }

        private void Page_Loaded(object sender, RoutedEventArgs e)
        {
            LoadData();
        }

        private async void LoadData()
        {
            TypesComboBox.ItemsSource = await pageController.GetTypesAsync();
            BrandsComboBox.ItemsSource = await pageController.GetBrandsAsync();

            if (mode == Modes.Edit)
            {
                TypesComboBox.SelectedItem = (TypesComboBox.ItemsSource as ObservableCollection<Device_Type>).FirstOrDefault(t => t.Id_Type == device.Device_Type.Id_Type);
                BrandsComboBox.SelectedItem = (BrandsComboBox.ItemsSource as ObservableCollection<Brand>).FirstOrDefault(b => b.Id_Brand == device.Device_Brand.Id_Brand);
            }
        }

        private async void AddNewDevice()
        {
            window.ShowProgressBar();
            if (!await pageController.AddNewDevice(device))
            {
                window.HideProgressBar();
                MessageBox.Show("Item already exists!", "Name error", MessageBoxButton.OK, MessageBoxImage.Error);
                EnableGrid();
                return;
            }
            LoadDevicesPage();
        }

        private async void UpdateDevice()
        {
            window.ShowProgressBar();
            if (!await pageController.UpdateDeviceAsync(device))
            {
                window.HideProgressBar();
                MessageBox.Show("Item already exists!", "Name error", MessageBoxButton.OK, MessageBoxImage.Error);
                EnableGrid();
                return;
            }
            LoadDevicesPage();
        }

        #region BUTTONS
        private void OkButton_Click(object sender, RoutedEventArgs e)
        {
            if (Validator.HasErrors(MainGrid)) return;
            DisableGrid();

            device.Device_Type = TypesComboBox.SelectedItem as Device_Type;
            device.Device_Brand = BrandsComboBox.SelectedItem as Brand;

            if (mode == Modes.Add)
                AddNewDevice();

            if (mode == Modes.Edit)
                UpdateDevice();
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

        private void DisableGrid()
        {
            MainGrid.IsEnabled = false;
        }

        private void EnableGrid()
        {
            MainGrid.IsEnabled = true;
        }
        #endregion
    }
}
