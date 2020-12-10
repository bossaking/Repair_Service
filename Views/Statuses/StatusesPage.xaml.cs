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
    public partial class StatusesPage : Page
    {
        StatusesPageController pageController;
        MainWindow window;
        public StatusesPage()
        {
            InitializeComponent();
            this.Loaded += StatusesPage_Loaded;
            pageController = new StatusesPageController();
        }

        private void StatusesPage_Loaded(object sender, RoutedEventArgs e)
        {
            window = (MainWindow)Application.Current.MainWindow;
            window.Title = "Repair Service: Statuses";
            LoadStatuses();
        }

        private async void LoadStatuses()
        {
            DataGrid.ItemsSource = await pageController.GetStatusesAsync();
        }

        public async void RefreshData()
        {
            if (await pageController.RefreshStatuses())
            {
                DataGrid.ItemsSource = await pageController.GetStatusesAsync();
                window.StopRefreshing();
            }
        }

        private async void DeleteStatus()
        {
            if (!await pageController.DeleteStatusAsync(DataGrid.SelectedItem as Status))
            {
                //MessageBox.Show("Selected item cannot be deleted!", "Delete error", MessageBoxButton.OK, MessageBoxImage.Error);

                ErrorWindow errorWindow = new ErrorWindow
                {
                    Owner = window
                };

                errorWindow.text = "Selected item cannot be deleted!";
                errorWindow.ShowDialog();
            }
        }

        #region BUTTONS


        private void DeleteButton_Click(object sender, RoutedEventArgs e)
        {
            //if (MessageBox.Show("Are you sure you want to remove the selected status?", "Delete status", MessageBoxButton.YesNo, MessageBoxImage.Question) != MessageBoxResult.Yes)
            //{
            //    return;
            //}
            //else
            //{
            //    DeleteStatus();
            //}

            DeleteWindow deleteWindow = new DeleteWindow
            {
                Owner = window
            };

            if (deleteWindow.ShowDialog() == true)
            {
                DeleteStatus();
            }
            else
            {
                return;
            }
        }

        private void AddButton_Click(object sender, RoutedEventArgs e)
        {
            AddEditStatusesPage addEditStatusPage = new AddEditStatusesPage(pageController, new Status(), Modes.Add);
            this.NavigationService.Navigate(addEditStatusPage);
        }

        private void EditButton_Click(object sender, RoutedEventArgs e)
        {
            Status status = new Status
            {
                Id_Status = (DataGrid.SelectedItem as Status).Id_Status,
                Title = (DataGrid.SelectedItem as Status).Title,
                Orders = (DataGrid.SelectedItem as Status).Orders
            };
            AddEditStatusesPage addEditStatusPage = new AddEditStatusesPage(pageController, status, Modes.Edit);
            this.NavigationService.Navigate(addEditStatusPage);
        }

        private void BackButton_Click(object sender, RoutedEventArgs e)
        {
            MainPage mainPage = new MainPage();
            this.NavigationService.Navigate(mainPage);
        }
        #endregion
    }
}
