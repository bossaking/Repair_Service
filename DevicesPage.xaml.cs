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
    /// <summary>
    /// Interaction logic for DevicesPage.xaml
    /// </summary>
    public partial class DevicesPage : Page
    {
        public DevicesPage()
        {
            InitializeComponent();
        }

        private void ButtonAddDevice(object sender, RoutedEventArgs e)
        {
            AddDevicePage addDevicePage = new AddDevicePage();
            this.NavigationService.Navigate(addDevicePage);
        }

        private void ButtonBackClick(object sender, RoutedEventArgs e)
        {
            MainPage mainPage = new MainPage();
            this.NavigationService.Navigate(mainPage);
        }

        private void ButtonEditClick(object sender, RoutedEventArgs e)
        {

        }

        private void ButtonDeleteClick(object sender, RoutedEventArgs e)
        {

        }
    }
}
