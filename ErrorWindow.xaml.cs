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
    public partial class ErrorWindow : Window
    {
        public string text { get; set; }

        public ErrorWindow()
        {
            InitializeComponent();
        }

        private void ErrorWindow_Loaded(object sender, RoutedEventArgs e)
        {
            ErrorText.Text = text;
        }

        private void YesButton_Click(object sender, RoutedEventArgs e)
        {
            Close();
        }
    }
}
