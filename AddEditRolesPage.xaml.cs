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
        public AddEditRolesPage()
        {
            InitializeComponent();
        }

        #region BUTTONS
        private void OkButton_Click(object sender, RoutedEventArgs e)
        {
            LoadRolesPage();
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
