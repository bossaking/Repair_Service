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
    public partial class RolesPage : Page
    {
        //TODO Dodać edycje
        //TODO Dodać Progress Bar
        RolesPageController pageController;
        public RolesPage()
        {
            InitializeComponent();
            this.Loaded += RolesPage_Loaded;
            pageController = new RolesPageController();
        }

        private void RolesPage_Loaded(object sender, RoutedEventArgs e)
        {
            LoadRoles();
        }

        private async void LoadRoles()
        {
            DataGrid.ItemsSource = await pageController.GetRolesAsync();
        }

        private async void DeleteRole()
        {
            if(! await pageController.DeleteRoleAsync(DataGrid.SelectedItem as Role))
            {
                MessageBox.Show("Selected item cannot be deleted!", "Delete error", MessageBoxButton.OK, MessageBoxImage.Error);
            }
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
        private void EditButton_Click(object sender, RoutedEventArgs e)
        {
            LoadAddEditRolePage();
        }

        private void DeleteButton_Click(object sender, RoutedEventArgs e)
        {
            if (MessageBox.Show("Are you sure you want to remove the selected role?", "Delete role",
                MessageBoxButton.YesNo, MessageBoxImage.Question) != MessageBoxResult.Yes)
            {
                return;
            }
            else
            {
                DeleteRole();
            }
        }

        private void AddButton_Click(object sender, RoutedEventArgs e)
        {
            AddEditRolesPage addEditRolesPage = new AddEditRolesPage(pageController, new Role(), Modes.Add);
            this.NavigationService.Navigate(addEditRolesPage);
        }

        private void BackButton_Click(object sender, RoutedEventArgs e)
        {
            MainPage mainPage = new MainPage();
            this.NavigationService.Navigate(mainPage);
        }

        private void LoadAddEditRolePage()
        {
            //AddEditRolesPage addEditRolesPage = new AddEditRolesPage();
            //this.NavigationService.Navigate(addEditRolesPage);
        }
        #endregion
    }
}
