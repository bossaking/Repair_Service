﻿using Repair_Service.Controllers;
using Repair_Service.Models;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
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
    public partial class MainPage : Page
    {
        private MainPageController mainPageController;

        public MainPage()
        {
            InitializeComponent();

            //Inicjalizacja kontrolera
            mainPageController = new MainPageController();
            
            
        }

        private void ButtonAddReportment(object sender, RoutedEventArgs e)
        {
            NewReportmentPage newReportmentPage = new NewReportmentPage();
            this.NavigationService.Navigate(newReportmentPage);
        }

        private void ButtonLogout(object sender, RoutedEventArgs e)
        {
            LoginPage loginPage = new LoginPage();
            this.NavigationService.Navigate(loginPage);
        }

        private void Page_Loaded(object sender, RoutedEventArgs e)
        {
            //Pobiranie wszystkich zleceń z bazy danych
            LoadAllOrders();
        }

        /// <summary>
        /// Metoda, pozwalająca na asynchroniczne pobieranie wszystkich zleceń z bazy danych
        /// </summary>
        private async void LoadAllOrders()
        {
            DataGrid.ItemsSource = await mainPageController.GetAllOrdersAsync();
        }
    }
}