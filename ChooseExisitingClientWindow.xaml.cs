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
using System.Windows.Shapes;
using Repair_Service.Controllers;
using Repair_Service.Models;

namespace Repair_Service
{
    public partial class ChooseExisitingClientWindow : Window
    {
        public Client client;

        ExistingClientWindowController windowController;
        public ChooseExisitingClientWindow()
        {
            InitializeComponent();
        }

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            windowController = new ExistingClientWindowController();
            GetClients();
        }

        private async void GetClients()
        {
            ClientsDataGrid.ItemsSource = await windowController.GetClientsAsync();
        }

        private void AddButton_Click(object sender, RoutedEventArgs e)
        {
            DialogResult = true;
            client = ClientsDataGrid.SelectedItem as Client;
            Close();
        }

        private void BackButton_Click(object sender, RoutedEventArgs e)
        {
            Close();
        }


    }
}
