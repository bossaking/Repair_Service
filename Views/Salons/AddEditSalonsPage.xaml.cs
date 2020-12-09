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
    public partial class AddEditSalonsPage : Page
    {
        SalonsPageController pageController;
        Salon salon;
        Modes mode;

        MainWindow window;
        public AddEditSalonsPage(SalonsPageController pageController, Salon salon, Modes mode)
        {
            InitializeComponent();

            this.pageController = pageController;
            this.salon = salon;
            this.mode = mode;

            window = Application.Current.MainWindow as MainWindow;

            DataContext = salon;
        }

        private async void AddNewSalon()
        {
            window.ShowProgressBar();
            if(! await pageController.AddNewSalonAsync(salon))
            {
                window.HideProgressBar();
                MessageBox.Show("Item already exists!", "Name error", MessageBoxButton.OK, MessageBoxImage.Error);
                EnableGrid();
                return;
            }
            LoadSalonsPage();
        }

        private async void UpdateSalon()
        {
            window.ShowProgressBar();
            if (!await pageController.UpdateSalonAsync(salon))
            {
                window.HideProgressBar();
                MessageBox.Show("Item already exists!", "Name error", MessageBoxButton.OK, MessageBoxImage.Error);
                EnableGrid();
                return;
            }
            LoadSalonsPage();
        }

        #region BUTTONS
        private void OkButton_Click(object sender, RoutedEventArgs e)
        {
            if (Validator.HasErrors(MainGrid)) return;
            DisableGrid();
            if (mode == Modes.Add)
                AddNewSalon();

            if (mode == Modes.Edit)
                UpdateSalon();
        }

        private void CancelButton_Click(object sender, RoutedEventArgs e)
        {
            LoadSalonsPage();
        }

        private void LoadSalonsPage()
        {
            SalonsPage salonsPage = new SalonsPage();
            this.NavigationService.Navigate(salonsPage);
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
