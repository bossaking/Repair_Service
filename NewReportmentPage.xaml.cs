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
using Repair_Service.Controllers;
using Repair_Service.Models;

namespace Repair_Service
{
    public partial class NewReportmentPage : Page
    {
        private ReportmentPageController reportmentPageController;
        private Order newOrder;

        public NewReportmentPage()
        {
            InitializeComponent();
            //TODO pole z problemami dodane, ale nie obsłużone w kodzie
            //TODO obsłużyć brand w kodzie
        }

        #region DATA
        private void NewReportmentPage_Loaded(object sender, RoutedEventArgs e)
        {
            DeviceTypeComboBox.SelectionChanged += DeviceTypeComboBox_SelectionChanged;

            reportmentPageController = new ReportmentPageController();
            newOrder = reportmentPageController.GetNewOrder();
            
            DataContext = newOrder;

            GetEmployees();
            GetTypes();
        }

        private async void GetEmployees()
        {
            EmployeesComboBox.ItemsSource = await reportmentPageController.GetEmployeesAsync();
        }

        private async void GetTypes()
        {
            DeviceTypeComboBox.ItemsSource = await reportmentPageController.GetTypesAsync();
        }

        private void DeviceTypeComboBox_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            if (DeviceTypeComboBox.SelectedItem != null)
            {
                DeviceModelComboBox.IsEnabled = true;
                DeviceModelComboBox.SelectedIndex = 0;
            }
        }
        #endregion

        #region BUTTONS
        private void SelectClientButton_Click(object sender, RoutedEventArgs e)
        {
            ChooseExisitingClientWindow chooseExisitingClientWindow = new ChooseExisitingClientWindow();
            chooseExisitingClientWindow.ShowDialog();
        }

        private void AddButton_Click(object sender, RoutedEventArgs e)
        {
            reportmentPageController.AddNewOrder(newOrder);
            LoadMainPage();
        }

        private void CancelButton_Click(object sender, RoutedEventArgs e)
        {
            LoadMainPage();
        }

        private void LoadMainPage()
        {
            MainPage mainPage = new MainPage();
            this.NavigationService.Navigate(mainPage);
        }
        #endregion
    }
}