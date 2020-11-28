﻿using Repair_Service.Controllers;
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

        public AddEditBrandsPage(BrandsPageController pageController, Brand brand, Modes mode)
        {
            this.pageController = pageController;
            this.brand = brand;
            DataContext = brand;
            this.mode = mode;
            InitializeComponent();
        }

        private async void AddNewBrand()
        {
            if(! await pageController.AddNewBrandAsync(brand))
            {
                MessageBox.Show("Jakiś tam error", "Error", MessageBoxButton.OK, MessageBoxImage.Error);
                return;
            }

            LoadBrandsPage();
        }

        private async void UpdateBrand()
        {
            if (!await pageController.UpdateBrandAsync(brand))
            {
                MessageBox.Show("Jakiś tam error", "Error", MessageBoxButton.OK, MessageBoxImage.Error);
                return;
            }

            LoadBrandsPage();
        }

        #region BUTTONS
        private void OkButton_Click(object sender, RoutedEventArgs e)
        {
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
        #endregion
    }
}
