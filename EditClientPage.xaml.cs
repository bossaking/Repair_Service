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
using TableDependency.SqlClient;
using System.Configuration;

namespace Repair_Service
{
    public partial class EditClientPage : Page
    {
        //TODO Dodać sprawdzenie czy wszystkie pola są wypełnione
        readonly EditClientPageController pageController;
        public EditClientPage(Client client)
        {
            InitializeComponent();
            DataContext = client;

            pageController = new EditClientPageController();
        }

        #region BUTTONS
        private void OkButton_Click(object sender, RoutedEventArgs e)
        {
            UpdateClient(DataContext as Client);
        }

        public async void UpdateClient(Client client)
        {
            if (!await pageController.UpdateClient(client))
            {
                //TODO Zmienić komunikat
                MessageBox.Show("Jakiś tam error", "Error", MessageBoxButton.OK, MessageBoxImage.Error);
                return;
            }

            LoadClientsPage();
        }

        private void CancelButton_Click(object sender, RoutedEventArgs e)
        {
            LoadClientsPage();
        }

        private void LoadClientsPage()
        {
            ClientsPage clientsPage = new ClientsPage();
            this.NavigationService.Navigate(clientsPage);
        }
        #endregion
    }
}
