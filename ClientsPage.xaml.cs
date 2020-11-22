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
            GetAllClients();
        }

        private async void GetAllClients()
        {
            DataGrid.ItemsSource = await clientsPageController.GetClientsAsync();
        }

        private async void DeleteClient()
        {
            if (!await clientsPageController.DeleteClient((DataGrid.SelectedItem as Client).Id_Client))
                MessageBox.Show("Jakiś tam error", "Error", MessageBoxButton.OK, MessageBoxImage.Error);
            //TODO Zamienić komunikat   
        }
        #endregion

        #region BUTTONS
        private void EditButton_Click(object sender, RoutedEventArgs e)
        {
            EditClientPage editClientPage = new EditClientPage((DataGrid.SelectedItem as Client));
            this.NavigationService.Navigate(editClientPage);
        }

        private void DeleteButton_Click(object sender, RoutedEventArgs e)
        {
            if (MessageBox.Show("Czy na pewno chcesz usunąć wybrany element?", "Usuń element",
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
