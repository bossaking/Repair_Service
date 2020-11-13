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
    /// <summary>
    /// Interaction logic for ChooseExisitingClientWindow.xaml
    /// </summary>
    public partial class ChooseExisitingClientWindow : Window
    {
        public ChooseExisitingClientWindow()
        {
            InitializeComponent();
        }

        private void ButtonAddClick(object sender, RoutedEventArgs e)
        {
            DialogResult = true;
        }

        private void ButtonBackClick(object sender, RoutedEventArgs e)
        {
            Close();
        }
    }
}
