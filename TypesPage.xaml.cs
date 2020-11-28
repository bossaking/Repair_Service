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
    public partial class TypesPage : Page
    {
        //TODO Dodać Progress Bar
        //TODO Dodać edycje

        TypesPageController pageController;
        public TypesPage()
        {
            InitializeComponent();
            this.Loaded += TypesPage_Loaded;
            pageController = new TypesPageController();
        }

        private void TypesPage_Loaded(object sender, RoutedEventArgs e)
        {
            GetTypes();
        }

        private async void DeleteType()
        {
            if(! await pageController.DeleteTypeAsync(DataGrid.SelectedItem as Device_Type))
            {
                MessageBox.Show("Selected item cannot be deleted!", "Delete error", MessageBoxButton.OK, MessageBoxImage.Error);
            }
        }

        private async void GetTypes()
        {
            DataGrid.ItemsSource = await pageController.GetTypesAsync();
        }

        #region PROGRESS BAR

        private void ShowProgressBar()
        {
            ProgressBar.Visibility = Visibility.Visible;
        }

        private void HideProgressBar()
        {
            ProgressBar.Visibility = Visibility.Hidden;
        }

        private void RefreshButton_Click(object sender, RoutedEventArgs e)
        {

        }

        #endregion

        #region BUTTONS


        private void DeleteButton_Click(object sender, RoutedEventArgs e)
        {
            if (MessageBox.Show("Are you sure you want to remove the selected type?", "Delete type",
                MessageBoxButton.YesNo, MessageBoxImage.Question) != MessageBoxResult.Yes)
            {
                return;
            }
            else
            {
                DeleteType();
            }
        }

        private void AddButton_Click(object sender, RoutedEventArgs e)
        {
            AddEditTypesPage addEditTypePage = new AddEditTypesPage(pageController, new Device_Type(), Modes.Add);
            this.NavigationService.Navigate(addEditTypePage);
        }

        private void EditButton_Click(object sender, RoutedEventArgs e)
        {
            Device_Type type = new Device_Type
            {
                Id_Type = (DataGrid.SelectedItem as Device_Type).Id_Type,
                Type_Title = (DataGrid.SelectedItem as Device_Type).Type_Title,
                Devices = (DataGrid.SelectedItem as Device_Type).Devices
            };
            AddEditTypesPage addEditTypePage = new AddEditTypesPage(pageController, type, Modes.Edit);
            this.NavigationService.Navigate(addEditTypePage);
        }

        private void BackButton_Click(object sender, RoutedEventArgs e)
        {
            MainPage mainPage = new MainPage();
            this.NavigationService.Navigate(mainPage);
        }
        #endregion
    }
}
