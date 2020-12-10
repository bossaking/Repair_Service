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
        readonly EditClientPageController pageController;
        MainWindow window;
        public EditClientPage(Client client)
        {
            window = (MainWindow)Application.Current.MainWindow;
            InitializeComponent();
            DataContext = client;

            pageController = new EditClientPageController();
        }

        #region BUTTONS
        private void OkButton_Click(object sender, RoutedEventArgs e)
        {
            if (Validator.HasErrors(MainGrid)) return;
            DisableGrid();
            UpdateClient(DataContext as Client);
        }

        public async void UpdateClient(Client client)
        {
            window.ShowProgressBar();
            if (!await pageController.UpdateClient(client))
            {
                window.HideProgressBar();

                ErrorWindow errorWindow = new ErrorWindow
                {
                    Owner = window
                };

                errorWindow.text = "Item already exists!";
                errorWindow.ShowDialog();

                //MessageBox.Show("Item already exists!", "Name error", MessageBoxButton.OK, MessageBoxImage.Error);
                EnableGrid();
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
            this.NavigationService.Navigate(new ClientsPage());
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
