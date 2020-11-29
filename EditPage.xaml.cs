using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
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
using Repair_Service.Controllers;
using Repair_Service.Models;


namespace Repair_Service
{
    /// <summary>
    /// Interaction logic for EditPage.xaml
    /// </summary>
    public partial class EditPage : Page
    {
        private Order newOrder;

        public EditPage()
        {
            InitializeComponent();
        }

        #region BUTTONS
        private void CancelButton_Click(object sender, RoutedEventArgs e)
        {
            LoadMainPage();
        }

        private void SaveButton_Click(object sender, RoutedEventArgs e)
        {
            LoadMainPage();
        }

        private void LoadMainPage()
        {
            MainPage mainPage = new MainPage();
            this.NavigationService.Navigate(mainPage);
        }
        #endregion

        private void SelectClientButton_Click(object sender, RoutedEventArgs e)
        {
            ChooseExisitingClientWindow chooseExisitingClientWindow = new ChooseExisitingClientWindow { Owner = Window.GetWindow(this) };
            if (chooseExisitingClientWindow.ShowDialog() == true)
            {
                //Client client = new Client
                //{
                //    Name = chooseExisitingClientWindow.client.Name,
                //    Surname = chooseExisitingClientWindow.client.Surname,
                //    Phone_Number = chooseExisitingClientWindow.client.Phone_Number
                //};
                //newOrder.Client = client;
            }
            //DataContext = null;
            //DataContext = newOrder;
        }
    }
}