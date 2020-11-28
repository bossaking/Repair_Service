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
    public partial class AddEditStatusesPage : Page
    {
        StatusesPageController pageController;
        Status status;
        Modes mode;

        public AddEditStatusesPage(StatusesPageController pageController, Status status, Modes mode)
        {
            InitializeComponent();

            this.pageController = pageController;
            this.status = status;
            this.mode = mode;

            DataContext = status;
        }

        private async void AddNewStatus()
        {
            if(! await pageController.AddNewStatusAsync(status))
            {
                MessageBox.Show("Item already exists!", "Name error", MessageBoxButton.OK, MessageBoxImage.Error);
                return;
            }
            LoadStatusesPage();
        }

        private async void UpdateStatus()
        {
            if (!await pageController.UpdateStatusAsync(status))
            {
                MessageBox.Show("Item already exists!", "Name error", MessageBoxButton.OK, MessageBoxImage.Error);
                return;
            }
            LoadStatusesPage();
        }

        #region BUTTONS
        private void OkButton_Click(object sender, RoutedEventArgs e)
        {
            if (mode == Modes.Add)
                AddNewStatus();

            if (mode == Modes.Edit)
                UpdateStatus();
        }

        private void CancelButton_Click(object sender, RoutedEventArgs e)
        {
            LoadStatusesPage();
        }

        private void LoadStatusesPage()
        {
            StatusesPage statusesPage = new StatusesPage();
            this.NavigationService.Navigate(statusesPage);
        }
        #endregion
    }
}
