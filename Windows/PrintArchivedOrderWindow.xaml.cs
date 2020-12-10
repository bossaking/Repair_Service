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
using System.Windows.Shapes;

namespace Repair_Service
{
    public partial class PrintArchivedOrderWindow : Window
    {
        Order order;
        public PrintArchivedOrderWindow(Order order)
        {
            this.order = order;
            InitializeComponent();
        }

        private void PrintArchivedOrderWindow_Loaded(object sender, RoutedEventArgs e)
        {
            dateLabel.Content = DateTime.Now;
            for(int i = 0; i < order.Problems.Count; i++)
            {
                problemsTextBlock.Text += order.Problems[i];
                if (i < order.Problems.Count - 1)
                    problemsTextBlock.Text += ", ";
            }
            DataContext = order;
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

            BackButton.Visibility = Visibility.Hidden;
            PrintButton.Visibility = Visibility.Hidden;

            PrintDialog printDialog = new PrintDialog();
            if (printDialog.ShowDialog() == true)
            {
                printDialog.PrintVisual(this, "Repair Service");
            }

            BackButton.Visibility = Visibility.Visible;
            PrintButton.Visibility = Visibility.Visible;
        }
    }
}
