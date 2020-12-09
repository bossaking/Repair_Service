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
    public partial class AddEditEmployeesPage : Page
    {
        EmployeesPageController pageController;
        Employee employee;
        Modes mode;

        MainWindow window;
        public AddEditEmployeesPage(EmployeesPageController pageController, Employee employee, Modes mode)
        {
            InitializeComponent();
            this.Loaded += AddEditEmployeesPage_Loaded;

            this.pageController = pageController;
            this.employee = employee;
            this.mode = mode;

            window = Application.Current.MainWindow as MainWindow;

            DataContext = employee;
        }

        private void AddEditEmployeesPage_Loaded(object sender, RoutedEventArgs e)
        {
            LoadData();
        }

        private async void LoadData()
        {
            SalonComboBox.ItemsSource = await pageController.GetSalonsAsync();
            RolesComboBox.ItemsSource = await pageController.GetRolesAsync();

            if(mode == Modes.Edit)
            {
                SalonComboBox.SelectedItem = (SalonComboBox.ItemsSource as ObservableCollection<Salon>).FirstOrDefault(s => s.Id_Salon == employee.Employee_Salon.Id_Salon);
                RolesComboBox.SelectedItem = (RolesComboBox.ItemsSource as ObservableCollection<Role>).FirstOrDefault(r => r.Id_Role == employee.Employee_Role.Id_Role);
            }
        }

        private async void AddNewEmployee()
        {
            window.ShowProgressBar();
            if(! await pageController.AddNewEmployeeAsync(employee))
            {
                window.HideProgressBar();
                MessageBox.Show("Item already exists!", "Name error", MessageBoxButton.OK, MessageBoxImage.Error);
                EnableGrid();
                return;
            }

            LoadEmployeesPage();
        }

        private async void UpdateEmployee()
        {
            window.ShowProgressBar();
            if (!await pageController.UpdateEmployeeAsync(employee))
            {
                window.HideProgressBar();
                MessageBox.Show("Item already exists!", "Name error", MessageBoxButton.OK, MessageBoxImage.Error);
                EnableGrid();
                return;
            }

            LoadEmployeesPage();
        }

        #region BUTTONS
        private void OkButton_Click(object sender, RoutedEventArgs e)
        {
            if (Validator.HasErrors(MainGrid)) return;
            DisableGrid();
            employee.Employee_Salon = SalonComboBox.SelectedItem as Salon;
            employee.Employee_Role = RolesComboBox.SelectedItem as Role;

            if (mode == Modes.Add)
                AddNewEmployee();

            if (mode == Modes.Edit)
                UpdateEmployee();
        }

        private void CancelButton_Click(object sender, RoutedEventArgs e)
        {
            LoadEmployeesPage();
        }

        private void LoadEmployeesPage()
        {
            EmployeesPage employeesPage = new EmployeesPage();
            this.NavigationService.Navigate(employeesPage);
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
