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
    public partial class AddEditTypesPage : Page
    {
        TypesPageController pageController;
        Device_Type type;
        Modes mode;

        MainWindow window;
        public AddEditTypesPage(TypesPageController pageController, Device_Type type, Modes mode)
        {
            InitializeComponent();
            this.mode = mode;
            this.type = type;
            DataContext = type;
            this.pageController = pageController;

            window = Application.Current.MainWindow as MainWindow;
        }

        private async void AddNewType()
        {
            window.ShowProgressBar();
            if(! await pageController.AddNewTypeAsync(type))
            {
                window.HideProgressBar();
                MessageBox.Show("Item already exists!", "Name error", MessageBoxButton.OK, MessageBoxImage.Error);
                EnableGrid();
                return;
            }
            LoadTypesPage();
        }

        private async void UpdateType()
        {
            window.ShowProgressBar();
            if (!await pageController.UpdateTypeAsync(type))
            {
                window.HideProgressBar();
                MessageBox.Show("Item already exists!", "Name error", MessageBoxButton.OK, MessageBoxImage.Error);
                EnableGrid();
                return;
            }
            LoadTypesPage();
        }

        #region BUTTONS
        private void OkButton_Click(object sender, RoutedEventArgs e)
        {
            DisableGrid();

            if(mode == Modes.Add)
                AddNewType();

            if (mode == Modes.Edit)
                UpdateType();
        }

        private void CancelButton_Click(object sender, RoutedEventArgs e)
        {
            LoadTypesPage();
        }

        private void LoadTypesPage()
        {
            TypesPage typesPage = new TypesPage();
            this.NavigationService.Navigate(typesPage);
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
