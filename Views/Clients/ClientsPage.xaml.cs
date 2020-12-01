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
    public partial class ClientsPage : Page
    {
        private ClientsPageController clientsPageController;
     
        public ClientsPage()
        {
            InitializeComponent();
            clientsPageController = new ClientsPageController();
        }

        #region DATA
        private void ClientsPage_Loaded(object sender, RoutedEventArgs e)
        {
            MainWindow window = (MainWindow)Application.Current.MainWindow;
            window.Title = "Repair Service: Clients";
            GetAllClients();
        }

        private async void GetAllClients()
        {
            DataGrid.ItemsSource = await clientsPageController.GetClientsAsync();
        }

        private async void DeleteClient()
        {
            if (!await clientsPageController.DeleteClient((DataGrid.SelectedItem as Client).Id_Client))
                MessageBox.Show("Selected item cannot be deleted!", "Delete error", MessageBoxButton.OK, MessageBoxImage.Error);
        }
        #endregion

        #region BUTTONS
        private void EditButton_Click(object sender, RoutedEventArgs e)
        {
            Client client = new Client
            {
                Id_Client = (DataGrid.SelectedItem as Client).Id_Client,
                Name = (DataGrid.SelectedItem as Client).Name,
                Surname = (DataGrid.SelectedItem as Client).Surname,
                Phone_Number = (DataGrid.SelectedItem as Client).Phone_Number,
                Orders = (DataGrid.SelectedItem as Client).Orders
            };
            EditClientPage editClientPage = new EditClientPage(client);
            this.NavigationService.Navigate(editClientPage);
        }

        private void DeleteButton_Click(object sender, RoutedEventArgs e)
        {
            if (MessageBox.Show("Are you sure you want to remove the selected client?", "Delete client",
                MessageBoxButton.YesNo, MessageBoxImage.Question) == MessageBoxResult.Yes)
                DeleteClient();
            
        }

        private void BackButton_Click(object sender, RoutedEventArgs e)
        {
            MainPage mainPage = new MainPage();
            this.NavigationService.Navigate(mainPage);
        }
        #endregion
    }
}
