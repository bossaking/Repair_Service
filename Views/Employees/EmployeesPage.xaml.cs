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
    public partial class EmployeesPage : Page
    {

        MainWindow window;

        EmployeesPageController pageController;
        public EmployeesPage()
        {
            InitializeComponent();
            this.Loaded += EmployeesPage_Loaded;
            pageController = new EmployeesPageController();
        }

        private void EmployeesPage_Loaded(object sender, RoutedEventArgs e)
        {
            window = (MainWindow)Application.Current.MainWindow;
            window.Title = "Repair Service: Employees";
            LoadEmployees();
        }

        private async void LoadEmployees()
        {
            DataGrid.ItemsSource = await pageController.GetEmployeesAsync();
        }

        private async void DeleteEmployee()
        {
            if(! await pageController.DeleteEmployeeAsync(DataGrid.SelectedItem as Employee))
            {
                MessageBox.Show("Selected item cannot be deleted!", "Delete error", MessageBoxButton.OK, MessageBoxImage.Error);
            }
        }

        public async void RefreshData()
        {
            if(await pageController.RefreshEmployees())
            {
                DataGrid.ItemsSource = await pageController.GetEmployeesAsync();
                window.StopRefreshing();
            }
            
        }

        #region BUTTONS

        private void DeleteButton_Click(object sender, RoutedEventArgs e)
        {
            if (MessageBox.Show("Are you sure you want to remove the selected employee?", "Delete employee",
                MessageBoxButton.YesNo, MessageBoxImage.Question) != MessageBoxResult.Yes)
            {
                return;
            }
            else
            {
                DeleteEmployee();
            }
        }

        private void AddButton_Click(object sender, RoutedEventArgs e)
        {
            AddEditEmployeesPage addEditEmployeePage = new AddEditEmployeesPage(pageController, new Employee(), Modes.Add);
            this.NavigationService.Navigate(addEditEmployeePage);
        }

        private void EditButton_Click(object sender, RoutedEventArgs e)
        {
            Employee employee = new Employee
            {
                Id_Employee = (DataGrid.SelectedItem as Employee).Id_Employee,
                Name = (DataGrid.SelectedItem as Employee).Name,
                Surname = (DataGrid.SelectedItem as Employee).Surname,
                Login = (DataGrid.SelectedItem as Employee).Login,
                Passwd = (DataGrid.SelectedItem as Employee).Passwd,
                Orders = (DataGrid.SelectedItem as Employee).Orders,
                Employee_Salon = (DataGrid.SelectedItem as Employee).Employee_Salon,
                Employee_Role = (DataGrid.SelectedItem as Employee).Employee_Role
            };
            AddEditEmployeesPage addEditEmployeePage = new AddEditEmployeesPage(pageController, employee, Modes.Edit);
            this.NavigationService.Navigate(addEditEmployeePage);
        }
        private void BackButton_Click(object sender, RoutedEventArgs e)
        {
            MainPage mainPage = new MainPage();
            this.NavigationService.Navigate(mainPage);
        }
        #endregion
    }
}
