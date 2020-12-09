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
    public partial class AddEditBrandsPage : Page
    {
        BrandsPageController pageController;
        Brand brand;
        Modes mode;
        MainWindow window;
        public AddEditBrandsPage(BrandsPageController pageController, Brand brand, Modes mode)
        {
            window = window = (MainWindow)Application.Current.MainWindow;
            this.pageController = pageController;
            this.brand = brand;
            DataContext = brand;
            this.mode = mode;
            InitializeComponent();
        }

        private async void AddNewBrand()
        {
            window.ShowProgressBar();
            if(! await pageController.AddNewBrandAsync(brand))
            {
                MessageBox.Show("Item already exists!", "Name error", MessageBoxButton.OK, MessageBoxImage.Error);
                window.HideProgressBar();
                EnableGrid();
                return;
            }

            LoadBrandsPage();
        }

        private async void UpdateBrand()
        {
            window.ShowProgressBar();
            if (!await pageController.UpdateBrandAsync(brand))
            {
                MessageBox.Show("Item already exists!", "Name error", MessageBoxButton.OK, MessageBoxImage.Error);
                window.HideProgressBar();
                EnableGrid();
                return;
            }

            LoadBrandsPage();
        }

        #region BUTTONS
        private void OkButton_Click(object sender, RoutedEventArgs e)
        {
            if (Validator.HasErrors(MainGrid)) return;
            DisableGrid();
            if(mode == Modes.Add)
                AddNewBrand();

            if (mode == Modes.Edit)
                UpdateBrand();
        }

        private void CancelButton_Click(object sender, RoutedEventArgs e)
        {
            LoadBrandsPage();
        }

        private void LoadBrandsPage()
        {
            BrandsPage brandsPage = new BrandsPage();
            this.NavigationService.Navigate(brandsPage);
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
