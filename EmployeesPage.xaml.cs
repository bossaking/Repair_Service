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
    public partial class EmployeesPage : Page
    {
        //TODO Sprawdzenie roli
        //TODO Dodać edycje
        //TODO Dodać Progress Bar

        EmployeesPageController pageController;
        public EmployeesPage()
        {
            InitializeComponent();
            this.Loaded += EmployeesPage_Loaded;
            pageController = new EmployeesPageController();
        }

        private void EmployeesPage_Loaded(object sender, RoutedEventArgs e)
        {
            LoadEmployees();
        }

        private async void LoadEmployees()
        {
            DataGrid.ItemsSource = await pageController.GetEmployeesAsync();
        }

        private async void DeleteEmployee()
        {
            if(! await pageController.DeleteEmployeeAsync(DataGrid.SelectedItem as Employee))
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
            LoadAddEditEmployeePage();
        }

        private void DeleteButton_Click(object sender, RoutedEventArgs e)
        {
            if (MessageBox.Show("Are you sure you want to remove the selected employee?", "Delete employee",
                MessageBoxButton.YesNo, MessageBoxImage.Question) != MessageBoxResult.Yes)
            {
                return;
            }
            else
            {
                DeleteEmployee();
            }
        }

        private void AddButton_Click(object sender, RoutedEventArgs e)
        {
            AddEditEmployeesPage addEditEmployeePage = new AddEditEmployeesPage(pageController, new Employee(), Modes.Add);
            this.NavigationService.Navigate(addEditEmployeePage);
        }

        private void BackButton_Click(object sender, RoutedEventArgs e)
        {
            MainPage mainPage = new MainPage();
            this.NavigationService.Navigate(mainPage);
        }

        private void LoadAddEditEmployeePage()
        {
            //AddEditEmployeesPage addEditEmployeePage = new AddEditEmployeesPage();
            //this.NavigationService.Navigate(addEditEmployeePage);
        }
        #endregion
    }
}
