using NHibernate.Criterion;
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
using System.Windows.Shapes;

namespace Repair_Service
{
    public partial class PrintArchivedOrderWindow : Window
    {
        public PrintArchivedOrderWindow()
        {
            InitializeComponent();
        }

        private void PrintArchivedOrderWindow_Loaded(object sender, RoutedEventArgs e)
        {
            //TODO Binding
        }

        private void BackButton_Click(object sender, RoutedEventArgs e)
        {
            Close();
        }

        private void Window_MouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            DragMove();
        }

        private void PrintButton_Click(object sender, RoutedEventArgs e)
        {
            //try
            //{
            //    NavigationGrid.Visibility = Visibility.Collapsed;
            //    this.IsEnabled = false;

            //    PrintDialog printDialog = new PrintDialog();
            //    if (printDialog.ShowDialog() == true)
            //    {
            //        printDialog.PrintVisual(this, "Something");
            //    }
            //}
            //finally
            //{
            //    NavigationGrid.Visibility = Visibility.Visible;
            //    this.IsEnabled = true;
            //}

            BackButton.Visibility = Visibility.Hidden;
            PrintButton.Visibility = Visibility.Hidden;

            PrintDialog printDialog = new PrintDialog();
            if (printDialog.ShowDialog() == true)
            {
                printDialog.PrintVisual(this, "Something");
            }

            BackButton.Visibility = Visibility.Visible;
            PrintButton.Visibility = Visibility.Visible;
        }
    }
}
