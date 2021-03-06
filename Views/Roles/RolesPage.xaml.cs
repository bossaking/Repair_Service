﻿using Repair_Service.Controllers;
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

        RolesPageController pageController;
        MainWindow window;
        public RolesPage()
        {
            InitializeComponent();
            this.Loaded += RolesPage_Loaded;
            pageController = new RolesPageController();
        }

        private void RolesPage_Loaded(object sender, RoutedEventArgs e)
        {
            window = (MainWindow)Application.Current.MainWindow;
            window.Title = "Repair Service: Roles";
            LoadRoles();
        }

        private async void LoadRoles()
        {
            DataGrid.ItemsSource = await pageController.GetRolesAsync();
        }

        public async void RefreshData()
        {
            if (await pageController.RefreshRoles())
            {
                DataGrid.ItemsSource = await pageController.GetRolesAsync();
                window.StopRefreshing();
            }
        }
        private async void DeleteRole()
        {
            if (!await pageController.DeleteRoleAsync(DataGrid.SelectedItem as Role))
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
            //if (MessageBox.Show("Are you sure you want to remove the selected role?", "Delete role",
            //    MessageBoxButton.YesNo, MessageBoxImage.Question) != MessageBoxResult.Yes)
            //{
            //    return;
            //}
            //else
            //{
            //    DeleteRole();
            //}

            DeleteWindow deleteWindow = new DeleteWindow
            {
                Owner = window
            };

            if (deleteWindow.ShowDialog() == true)
            {
                DeleteRole();
            }
            else
            {
                return;
            }
        }

        private void AddButton_Click(object sender, RoutedEventArgs e)
        {
            AddEditRolesPage addEditRolesPage = new AddEditRolesPage(pageController, new Role(), Modes.Add);
            this.NavigationService.Navigate(addEditRolesPage);
        }

        private void EditButton_Click(object sender, RoutedEventArgs e)
        {
            Role role = new Role
            {
                Id_Role = (DataGrid.SelectedItem as Role).Id_Role,
                Title = (DataGrid.SelectedItem as Role).Title,
                Employees = (DataGrid.SelectedItem as Role).Employees
            };
            AddEditRolesPage addEditRolesPage = new AddEditRolesPage(pageController, role, Modes.Edit);
            this.NavigationService.Navigate(addEditRolesPage);
        }

        private void BackButton_Click(object sender, RoutedEventArgs e)
        {
            MainPage mainPage = new MainPage();
            this.NavigationService.Navigate(mainPage);
        }
        #endregion
    }
}
