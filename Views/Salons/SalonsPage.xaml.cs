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
    public partial class SalonsPage : Page
    {
        SalonsPageController pageController;
        MainWindow window;
        public SalonsPage()
        {
            InitializeComponent();
            this.Loaded += SalonsPage_Loaded;
            pageController = new SalonsPageController();
        }

        private void SalonsPage_Loaded(object sender, RoutedEventArgs e)
        {
            window = (MainWindow)Application.Current.MainWindow;
            window.Title = "Repair Service: Salons";
            LoadSalons();
        }

        private async void LoadSalons()
        {
            DataGrid.ItemsSource = await pageController.GetSalonsAsync();
        }


        public async void RefreshData()
        {
            if (await pageController.RefreshSalons())
            {
                DataGrid.ItemsSource = await pageController.GetSalonsAsync();
                window.StopRefreshing();
            }
        }

        private async void DeleteSalon()
        {
            if (!await pageController.DeleteSalonAsync(DataGrid.SelectedItem as Salon))
            {
                MessageBox.Show("Selected item cannot be deleted!", "Delete error", MessageBoxButton.OK, MessageBoxImage.Error);
            }
        }

        #region BUTTONS


        private void DeleteButton_Click(object sender, RoutedEventArgs e)
        {
            if (MessageBox.Show("Are you sure you want to remove the selected salon?", "Delete salon",
                MessageBoxButton.YesNo, MessageBoxImage.Question) != MessageBoxResult.Yes)
            {
                return;
            }
            else
            {
                DeleteSalon();
            }
        }

        private void AddButton_Click(object sender, RoutedEventArgs e)
        {
            AddEditSalonsPage addEditSalonPage = new AddEditSalonsPage(pageController, new Salon(), Modes.Add);
            this.NavigationService.Navigate(addEditSalonPage);
        }

        private void EditButton_Click(object sender, RoutedEventArgs e)
        {
            Salon salon = new Salon
            {
                Id_Salon = (DataGrid.SelectedValue as Salon).Id_Salon,
                Title = (DataGrid.SelectedValue as Salon).Title,
                Location = (DataGrid.SelectedValue as Salon).Location,
                Employees = (DataGrid.SelectedValue as Salon).Employees
            };
            AddEditSalonsPage addEditSalonPage = new AddEditSalonsPage(pageController, salon, Modes.Edit);
            this.NavigationService.Navigate(addEditSalonPage);
        }

        private void BackButton_Click(object sender, RoutedEventArgs e)
        {
            MainPage mainPage = new MainPage();
            this.NavigationService.Navigate(mainPage);
        }
        #endregion
    }
}
