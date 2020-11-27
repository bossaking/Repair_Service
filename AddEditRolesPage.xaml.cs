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
    /// <summary>
    /// Interaction logic for AddEditRolesPage.xaml
    /// </summary>
    public partial class AddEditRolesPage : Page
    {
        RolesPageController pageController;
        Role role;
        Modes mode;
        public AddEditRolesPage(RolesPageController pageController, Role role, Modes mode)
        {
            InitializeComponent();

            this.pageController = pageController;
            this.role = role;
            this.mode = mode;

            DataContext = role;
        }

        private async void AddNewRole()
        {
            if(! await pageController.AddNewRoleAsync(role))
            {
                MessageBox.Show("Item already exists!", "Name error", MessageBoxButton.OK, MessageBoxImage.Error);
                return;
            }
            LoadRolesPage();
        }

        #region BUTTONS
        private void OkButton_Click(object sender, RoutedEventArgs e)
        {
            if (mode == Modes.Add)
                AddNewRole();
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
        #endregion
    }
}
