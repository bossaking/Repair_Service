using Repair_Service.Controllers;
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
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }


        private void Window_Loaded(object sender, RoutedEventArgs e)
        {

        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            //MainController.AddNewBrand();
            //MainController.AddNewClient();
            //MainController.AddNewProblem();
            //MainController.AddNewRole();
            //MainController.AddNewSalon();
            //MainController.AddNewType();
            //MainController.AddNewDevice();
            //MainController.AddNewEmployee();
            MainController.AddNewOrder();


        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            //MainController.GetAllOrders();
            MainController.GetAllBrands();
        }

        private void EditButtonClick(object sender, RoutedEventArgs e)
        {
            MainController.SetOrder();
        }

        private void DeleteButtonClick(object sender, RoutedEventArgs e)
        {
            MainController.DeleteOrder();
            //MainController.DeleteProblem();
            //MainController.DeleteEmployee();
        }
    }
}
