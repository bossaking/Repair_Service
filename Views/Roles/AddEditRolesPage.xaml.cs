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

    public partial class AddEditRolesPage : Page
    {
        RolesPageController pageController;
        Role role;
        Modes mode;

        MainWindow window;
        public AddEditRolesPage(RolesPageController pageController, Role role, Modes mode)
        {
            InitializeComponent();

            this.pageController = pageController;
            this.role = role;
            this.mode = mode;

            window = Application.Current.MainWindow as MainWindow;

            DataContext = role;
        }

        private async void AddNewRole()
        {
            window.ShowProgressBar();
            if (!await pageController.AddNewRoleAsync(role))
            {
                window.HideProgressBar();
                MessageBox.Show("Item already exists!", "Name error", MessageBoxButton.OK, MessageBoxImage.Error);
                EnableGrid();
                return;
            }
            LoadRolesPage();
        }

        private async void UpdateRole()
        {
            window.ShowProgressBar();
            if (!await pageController.UpdateRoleAsync(role))
            {
                window.HideProgressBar();
                MessageBox.Show("Item already exists!", "Name error", MessageBoxButton.OK, MessageBoxImage.Error);
                EnableGrid();
                return;
            }
            LoadRolesPage();
        }

        #region BUTTONS
        private void OkButton_Click(object sender, RoutedEventArgs e)
        {
            if (Validator.HasErrors(MainGrid)) return;
            DisableGrid();
            if (mode == Modes.Add)
                AddNewRole();

            if (mode == Modes.Edit)
                UpdateRole();
        }

        private void CancelButton_Click(object sender, RoutedEventArgs e)
        {
            LoadRolesPage();
        }

        private void LoadRolesPage()
        {
            RolesPage rolesPage = new RolesPage();
            this.NavigationService.Navigate(rolesPage);
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
