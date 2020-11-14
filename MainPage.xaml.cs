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
    public partial class MainPage : Page
    {
        private MainPageController mainPageController;

        public MainPage()
        {
            InitializeComponent();

            //Inicjalizacja kontrolera
            mainPageController = new MainPageController();
        }

        #region DATA
        private void MainPage_Loaded(object sender, RoutedEventArgs e)
        {
            //Pobieranie wszystkich zleceń z bazy danych
            LoadAllOrders();
        }

        private async void LoadAllOrders()
        {
            DataGrid.ItemsSource = await mainPageController.GetAllOrdersAsync();
        }

        private async void DeleteOrder()
        {
            await mainPageController.DeleteOrder((DataGrid.SelectedItem as Order).Id_Order);
        }
        #endregion

        #region ACTION BUTTONS
        private void EditButton_Click(object sender, RoutedEventArgs e)
        {
            EditPage editPage = new EditPage();
            this.NavigationService.Navigate(editPage);
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
                DeleteOrder();
            }
        }

        private void AddReportmentButton_Click(object sender, RoutedEventArgs e)
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

        }

        private void BrandsButton_Click(object sender, RoutedEventArgs e)
        {

        }

        private void ProblemsButton_Click(object sender, RoutedEventArgs e)
        {

        }

        private void EmployeesButton_Click(object sender, RoutedEventArgs e)
        {

        }

        private void RolesButton_Click(object sender, RoutedEventArgs e)
        {

        }

        private void SalonsButton_Click(object sender, RoutedEventArgs e)
        {

        }

        private void LogoutButton_Click(object sender, RoutedEventArgs e)
        {
            LoginPage loginPage = new LoginPage();
            this.NavigationService.Navigate(loginPage);
        }
        #endregion
    }
}
