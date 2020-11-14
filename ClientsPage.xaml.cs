using Repair_Service.Controllers;
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

        private void Page_Loaded(object sender, RoutedEventArgs e)
        {
            GetAllClients();
        }

        private void ButtonEditClick(object sender, RoutedEventArgs e)
        {

        }

        private void ButtonDeleteClick(object sender, RoutedEventArgs e)
        {

        }

        private void ButtonBackClick(object sender, RoutedEventArgs e)
        {
            MainPage mainPage = new MainPage();
            this.NavigationService.Navigate(mainPage);
        }

        private async void GetAllClients()
        {
            DataGrid.ItemsSource = await clientsPageController.GetClientsAsync();
        }


    }
}
