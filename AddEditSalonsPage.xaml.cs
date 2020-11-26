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
    public partial class AddEditSalonsPage : Page
    {
        public AddEditSalonsPage()
        {
            InitializeComponent();
        }

        #region BUTTONS
        private void OkButton_Click(object sender, RoutedEventArgs e)
        {
            LoadSalonsPage();
        }

        private void CancelButton_Click(object sender, RoutedEventArgs e)
        {
            LoadSalonsPage();
        }

        private void LoadSalonsPage()
        {
            SalonsPage salonsPage = new SalonsPage();
            this.NavigationService.Navigate(salonsPage);
        }
        #endregion
    }
}