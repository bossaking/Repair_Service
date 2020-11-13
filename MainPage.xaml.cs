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
        public Collection<Reportment> Reportments { get; } = new ObservableCollection<Reportment>();

        public MainPage()
        {
            InitializeComponent();
            Reportments.Add(new Reportment { Id = 1, Name = "Mateusz Paszko", PhoneNumber = "123456789", ModelTitle = "Samsung Galaxy S7", Type = "Smartfon", OrderDate = "25.10.2020", Status = "W trakcie naprawy" });
            Reportments.Add(new Reportment { Id = 2, Name = "Gabriel Czajkowski", PhoneNumber = "123456789", ModelTitle = "Lenovo Legion 5", Type = "Laptop", OrderDate = "01.11.2020", Status = "Przyjęty" });
            Reportments.Add(new Reportment { Id = 3, Name = "Dzmitry Drahaliou", PhoneNumber = "123456789", ModelTitle = "Nokia 3310", Type = "Telefon", OrderDate = "29.09.2020", Status = "Zakończony" });
            Reportments.Add(new Reportment { Id = 4, Name = "Michał Mirończuk", PhoneNumber = "123456789", ModelTitle = "OnePlus 8T", Type = "Smartfon", OrderDate = "31.10.2020", Status = "Przyjęty" });

            DataGrid.ItemsSource = Reportments;
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
    }
}
