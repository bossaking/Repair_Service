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
using Repair_Service.DAL;

namespace Repair_Service
{
    //XDDDD
    //Kolejny kom
    public partial class MainWindow : Window
    {

        Database database;
        public MainWindow()
        {
            database = new Database();
            InitializeComponent();
        }


        private void Window_Loaded(object sender, RoutedEventArgs e)
        {

        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            database.AddNewBrand();
            database.AddNewClient();
            database.AddNewProblem();
            database.AddNewRole();
            database.AddNewSalon();
            database.AddNewType();
            database.AddNewDevice();
            database.AddNewEmployee();
            database.AddNewOrder();


        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            database.GetAllOrders();
            database.GetAllBrands();
            database.GetAllProblems();
        }

        private void EditButtonClick(object sender, RoutedEventArgs e)
        {
            database.SetOrder();
        }

        private void DeleteButtonClick(object sender, RoutedEventArgs e)
        {
            database.DeleteOrder();
            database.DeleteProblem();
            database.DeleteEmployee();
        }
    }
}
