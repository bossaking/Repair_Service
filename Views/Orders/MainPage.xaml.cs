using Repair_Service.Controllers;
using Repair_Service.Models;
using System;
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

namespace Repair_Service
{
    public partial class MainPage : Page
    {
        private MainPageController mainPageController;
        MainWindow window;
        public MainPage()
        {
            InitializeComponent();

            //Inicjalizacja kontrolera
            mainPageController = new MainPageController();
        }

        #region DATA
        private void MainPage_Loaded(object sender, RoutedEventArgs e)
        {
            window = (MainWindow)Application.Current.MainWindow;
            window.Title = "Repair Service: Orders";

            var dpd = DependencyPropertyDescriptor.FromProperty(ItemsControl.ItemsSourceProperty, typeof(DataGrid));
            if(dpd != null)
            {
                dpd.AddValueChanged(DataGrid, DataGridItemSourceChanged);
            }

            if (mainPageController.IsAdministrator())
                AdministratorPanel.Visibility = Visibility.Visible;

            //Pobieranie wszystkich zleceń z bazy danych
            LoadAllOrders();
        }

        private void DataGridItemSourceChanged(object sender, EventArgs eventArgs)
        {
            //HideProgressBar();
        }

        private async void LoadAllOrders()
        {
            DataGrid.ItemsSource = await mainPageController.GetAllOrdersAsync();
        }

        public async void RefreshData()
        {
            if(await mainPageController.RefreshOrders())
            {
                DataGrid.ItemsSource = await mainPageController.GetAllOrdersAsync();
                window.StopRefreshing();
            }
        }

        #endregion

        #region ACTION BUTTONS
        private void EditButton_Click(object sender, RoutedEventArgs e)
        {
            Order order = new Order()
            {
                Id_Order = (DataGrid.SelectedValue as Order).Id_Order,
                Client = (DataGrid.SelectedValue as Order).Client,
                Description = (DataGrid.SelectedValue as Order).Description,
                Device = (DataGrid.SelectedValue as Order).Device,
                Order_Date = (DataGrid.SelectedValue as Order).Order_Date,
                Employee = (DataGrid.SelectedValue as Order).Employee,
                Price = (DataGrid.SelectedValue as Order).Price,
                Problems = (DataGrid.SelectedValue as Order).Problems,
                Status = (DataGrid.SelectedValue as Order).Status,
                Reception_Date = (DataGrid.SelectedValue as Order).Reception_Date
            };
            EditPage editPage = new EditPage(order);
            this.NavigationService.Navigate(editPage);
        }

        private void AddButton_Click(object sender, RoutedEventArgs e)
        {
            NewReportmentPage newReportmentPage = new NewReportmentPage();
            this.NavigationService.Navigate(newReportmentPage);
        }
        #endregion

        #region NAVIGATION BUTTONS
        private void ClientsButton_Click(object sender, RoutedEventArgs e)
        {
            ClientsPage clientsPage = new ClientsPage();
            this.NavigationService.Navigate(clientsPage);
        }

        private void DevicesButton_Click(object sender, RoutedEventArgs e)
        {
            DevicesPage devicesPage = new DevicesPage();
            this.NavigationService.Navigate(devicesPage);
        }

        private void TypesButton_Click(object sender, RoutedEventArgs e)
        {
            TypesPage typesPage = new TypesPage();
            this.NavigationService.Navigate(typesPage);
        }

        private void BrandsButton_Click(object sender, RoutedEventArgs e)
        {
            BrandsPage brandsPage = new BrandsPage();
            this.NavigationService.Navigate(brandsPage);
        }

        private void ProblemsButton_Click(object sender, RoutedEventArgs e)
        {
            ProblemsPage problemsPage = new ProblemsPage();
            this.NavigationService.Navigate(problemsPage);
        }

        private void EmployeesButton_Click(object sender, RoutedEventArgs e)
        {
            EmployeesPage employeesPage = new EmployeesPage();
            this.NavigationService.Navigate(employeesPage);
        }

        private void RolesButton_Click(object sender, RoutedEventArgs e)
        {
            RolesPage rolesPage = new RolesPage();
            this.NavigationService.Navigate(rolesPage);
        }

        private void SalonsButton_Click(object sender, RoutedEventArgs e)
        {
            SalonsPage salonsPage = new SalonsPage();
            this.NavigationService.Navigate(salonsPage);
        }

        private void LogoutButton_Click(object sender, RoutedEventArgs e)
        {
            LoginPage loginPage = new LoginPage();
            this.NavigationService.Navigate(loginPage);
        }

        private void ArchiveButton_Click(object sender, RoutedEventArgs e)
        {
            ArchivePage archivePage = new ArchivePage();
            this.NavigationService.Navigate(archivePage);
        }

        private void StatusesButton_Click(object sender, RoutedEventArgs e)
        {
            StatusesPage statusesPage = new StatusesPage();
            this.NavigationService.Navigate(statusesPage);
        }
        #endregion
    }
}
