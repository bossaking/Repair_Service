using System;
using System.Collections;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
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
using Repair_Service.Controllers;
using Repair_Service.Models;


namespace Repair_Service
{
    public partial class EditPage : Page
    {
        ReportmentPageController pageController;
        private Order order;
        MainWindow window;
        public EditPage(Order order)
        {
            InitializeComponent();

            this.pageController = new ReportmentPageController();
            this.order = order;

            DataContext = order;

            DeviceTypeComboBox.SelectionChanged += DeviceTypeComboBox_SelectionChanged;
            DeviceBrandComboBox.SelectionChanged += DeviceBrandComboBox_SelectionChanged;
            var dpd = DependencyPropertyDescriptor.FromProperty(ItemsControl.ItemsSourceProperty, typeof(ComboBox));
            if (dpd != null)
            {
                dpd.AddValueChanged(DeviceModelComboBox, ModelsComboBoxItemSourceChanged);
            }
        }

        private void Page_Loaded(object sender, RoutedEventArgs e)
        {
            window = (MainWindow)Application.Current.MainWindow;
            window.Title = "Repair Service: Edit order";
            EditPage_Loaded(sender, e);
        }

        private void DeviceTypeComboBox_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            if (DeviceTypeComboBox.SelectedItem != null)
            {
                DeviceBrandComboBox.ItemsSource = pageController.GetBrandsofType(DeviceTypeComboBox.SelectedItem as Device_Type);
                DeviceBrandComboBox.IsEnabled = true;
                DeviceBrandComboBox.SelectedItem = (DeviceBrandComboBox.ItemsSource as ObservableCollection<Brand>).FirstOrDefault(b => b.Id_Brand == order.Device.Device_Brand.Id_Brand);
                if (DeviceBrandComboBox.SelectedItem == null)
                    DeviceBrandComboBox.SelectedIndex = 0;
            }
        }

        private void DeviceBrandComboBox_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            if (DeviceBrandComboBox.SelectedItem != null)
            {
                DeviceModelComboBox.ItemsSource = pageController.GetDevicesOfTypeAndBrand(DeviceTypeComboBox.SelectedItem as Device_Type,
                    DeviceBrandComboBox.SelectedItem as Brand);
                DeviceModelComboBox.IsEnabled = true;
                DeviceModelComboBox.SelectedItem = (DeviceModelComboBox.ItemsSource as IList<Device>).FirstOrDefault(d => d.Id_Device == order.Device.Id_Device);
                if (DeviceModelComboBox.SelectedItem == null)
                    DeviceModelComboBox.SelectedIndex = 0;
            }
        }

        private void ModelsComboBoxItemSourceChanged(object sender, EventArgs e)
        {
            if (DeviceModelComboBox.Items.Count == 0)
            {
                DeviceModelComboBox.IsEnabled = false;
            }
        }

        private void EditPage_Loaded(object sender, RoutedEventArgs e)
        {
            LoadAllData();
        }

        private async void LoadAllData()
        {
            DeviceTypeComboBox.ItemsSource = await pageController.GetTypesAsync();
            DeviceTypeComboBox.SelectedItem = (DeviceTypeComboBox.ItemsSource as ObservableCollection<Device_Type>).FirstOrDefault(t => t.Id_Type == order.Device.Device_Type.Id_Type);

            EmployeesComboBox.ItemsSource = await pageController.GetEmployeesAsync();
            EmployeesComboBox.SelectedItem = (EmployeesComboBox.ItemsSource as ObservableCollection<Employee>).FirstOrDefault(e => e.Id_Employee == order.Employee.Id_Employee);

            StatusComboBox.ItemsSource = await pageController.GetStatusesAsync();
            StatusComboBox.SelectedItem = (StatusComboBox.ItemsSource as ObservableCollection<Status>).FirstOrDefault(s => s.Id_Status == order.Status.Id_Status);

            ProblemsComboBox.ItemsSource = await pageController.GetProblemsAsync();
            ProblemsComboBox.SelectedItems = (IList)order.Problems;
        }

        private async void UpdateOrder()
        {
            order.Device = DeviceModelComboBox.SelectedItem as Device;
            order.Employee = EmployeesComboBox.SelectedItem as Employee;
            order.Status = StatusComboBox.SelectedItem as Status;
            if (!await pageController.UpdateOrderAsync(order))
            {
                MessageBox.Show("Something went wrong...Try again", "Error", MessageBoxButton.OK, MessageBoxImage.Error);
                window.HideProgressBar();
                EnableGrid();
                return;
            }
            LoadMainPage();
        }

        #region BUTTONS
        private void CancelButton_Click(object sender, RoutedEventArgs e)
        {
            LoadMainPage();
        }

        private void SaveButton_Click(object sender, RoutedEventArgs e)
        {
            if (Validator.HasErrors(MainGrid)) return;
            MainGrid.IsEnabled = false;
            window.ShowProgressBar();
            UpdateOrder();
        }

        private void LoadMainPage()
        {
            this.NavigationService.Navigate(new MainPage());
        }
        #endregion

        private void SelectClientButton_Click(object sender, RoutedEventArgs e)
        {
            ChooseExisitingClientWindow chooseExisitingClientWindow = new ChooseExisitingClientWindow { Owner = Window.GetWindow(this) };
            if (chooseExisitingClientWindow.ShowDialog() == true)
            {
                order.Client = chooseExisitingClientWindow.client;
            }
            DataContext = null;
            DataContext = order;
        }

        private void EnableGrid()
        {
            MainGrid.IsEnabled = true;
        }
    }
}