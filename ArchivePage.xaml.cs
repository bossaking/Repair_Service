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
    /// <summary>
    /// Interaction logic for ArchivePage.xaml
    /// </summary>
    public partial class ArchivePage : Page
    {
        public ArchivePage()
        {
            InitializeComponent();
        }

        private void BackButton_Click(object sender, RoutedEventArgs e)
        {
            MainPage mainPage = new MainPage();
            this.NavigationService.Navigate(mainPage);
        }

        private void DetailsButton_Click(object sender, RoutedEventArgs e)
        {
            ArchieveDetailsPage archieveDetailsPage = new ArchieveDetailsPage();
            this.NavigationService.Navigate(archieveDetailsPage);
        }

        private void RestoreButton_Click(object sender, RoutedEventArgs e)
        {

        }
    }
}