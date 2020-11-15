﻿using System;
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
        public EmployeesPage()
        {
            InitializeComponent();
        }

        #region BUTTONS
        private void EditButton_Click(object sender, RoutedEventArgs e)
        {
            LoadAddEditEmployeePage();
        }

        private void DeleteButton_Click(object sender, RoutedEventArgs e)
        {
            if (MessageBox.Show("Czy na pewno chcesz usunąć wybrany element?", "Usuń element",
                MessageBoxButton.YesNo, MessageBoxImage.Question) != MessageBoxResult.Yes)
            {
                return;
            }
            else
            {
                //DeleteEmployee();
            }
        }

        private void AddButton_Click(object sender, RoutedEventArgs e)
        {
            LoadAddEditEmployeePage();
        }

        private void BackButton_Click(object sender, RoutedEventArgs e)
        {
            MainPage mainPage = new MainPage();
            this.NavigationService.Navigate(mainPage);
        }

        private void LoadAddEditEmployeePage()
        {
            AddEditEmployeesPage addEditEmployeePage = new AddEditEmployeesPage();
            this.NavigationService.Navigate(addEditEmployeePage);
        }
        #endregion
    }
}
