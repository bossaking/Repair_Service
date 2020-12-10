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
        BrandsPageController pageController;
        MainWindow window;

        public BrandsPage()
        {
            InitializeComponent();
            this.Loaded += BrandsPage_Loaded;
            pageController = new BrandsPageController();
        }

        private void BrandsPage_Loaded(object sender, RoutedEventArgs e)
        {
            window = (MainWindow)Application.Current.MainWindow;
            window.Title = "Repair Service: Brands";
            LoadBrands();
        }

        private async void LoadBrands()
        {
            DataGrid.ItemsSource = await pageController.GetBrandsAsync();
        }

        public async void RefreshData()
        {
            if (await pageController.RefreshBrands())
            {
                DataGrid.ItemsSource = await pageController.GetBrandsAsync();
                window.StopRefreshing();
            }
        }

        #region BUTTONS


        private async void DeleteBrand()
        {
            window.ShowProgressBar();
            if (!await pageController.DeleteBrandAsync(DataGrid.SelectedItem as Brand))
            {
                window.HideProgressBar();
                MessageBox.Show("Selected item cannot be deleted!", "Delete error", MessageBoxButton.OK, MessageBoxImage.Error);
            }
        }

        private void DeleteButton_Click(object sender, RoutedEventArgs e)
        {
            //if (MessageBox.Show("Are you sure you want to remove the selected brand?", "Delete brand",
            //    MessageBoxButton.YesNo, MessageBoxImage.Question) != MessageBoxResult.Yes)
            //{
            //    return;
            //}
            //else
            //{
            //    DeleteBrand();
            //}

            DeleteWindow deleteWindow = new DeleteWindow
            {
                Owner = window
            };

            if (deleteWindow.ShowDialog() == true)
            {
                DeleteBrand();
            }
            else
            {
                return;
            }
        }

        private void AddButton_Click(object sender, RoutedEventArgs e)
        {
            AddEditBrandsPage addEditBrandPage = new AddEditBrandsPage(pageController, new Brand(), Modes.Add);
            this.NavigationService.Navigate(addEditBrandPage);
        }

        private void EditButton_Click(object sender, RoutedEventArgs e)
        {
            Brand brand = new Brand
            {
                Id_Brand = (DataGrid.SelectedItem as Brand).Id_Brand,
                Title = (DataGrid.SelectedItem as Brand).Title,
                Devices = (DataGrid.SelectedItem as Brand).Devices
            };
            AddEditBrandsPage addEditBrandPage = new AddEditBrandsPage(pageController, brand, Modes.Edit);
            this.NavigationService.Navigate(addEditBrandPage);
        }

        private void BackButton_Click(object sender, RoutedEventArgs e)
        {
            MainPage mainPage = new MainPage();
            this.NavigationService.Navigate(mainPage);
        }
        #endregion
    }
}
