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
    public partial class BrandsPage : Page
    {
        //TODO Dodać edycje
        //TODO Dodać Progress Bar
        BrandsPageController pageController;
        public BrandsPage()
        {
            InitializeComponent();
            this.Loaded += BrandsPage_Loaded;
            pageController = new BrandsPageController();
        }

        private void BrandsPage_Loaded(object sender, RoutedEventArgs e)
        {
            LoadBrands();
        }

        private async void LoadBrands()
        {
            DataGrid.ItemsSource = await pageController.GetBrandsAsync();
        }

        #region BUTTONS
        private void EditButton_Click(object sender, RoutedEventArgs e)
        {
            LoadAddEditBrandPage();
        }

        private async void DeleteBrand()
        {
            if(! await pageController.DeleteBrandAsync(DataGrid.SelectedItem as Brand))
            {
                MessageBox.Show("Jakiś tam error", "Error", MessageBoxButton.OK, MessageBoxImage.Error);
            }
        }

        private void DeleteButton_Click(object sender, RoutedEventArgs e)
        {
            if (MessageBox.Show("Czy na pewno chcesz usunąć wybrany element?", "Usuń element",
                MessageBoxButton.YesNo, MessageBoxImage.Question) != MessageBoxResult.Yes)
            {
                return;
            }
            else
            {
                DeleteBrand();
            }
        }

        private void AddButton_Click(object sender, RoutedEventArgs e)
        {
            AddEditBrandsPage addEditBrandPage = new AddEditBrandsPage(pageController, new Brand(), Modes.Add);
            this.NavigationService.Navigate(addEditBrandPage);
        }

        private void BackButton_Click(object sender, RoutedEventArgs e)
        {
            MainPage mainPage = new MainPage();
            this.NavigationService.Navigate(mainPage);
        }

        private void LoadAddEditBrandPage()
        {
            //AddEditBrandsPage addEditBrandPage = new AddEditBrandsPage();
            //this.NavigationService.Navigate(addEditBrandPage);
        }
        #endregion
    }
}
