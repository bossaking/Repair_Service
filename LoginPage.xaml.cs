using Repair_Service.Controllers;
using Repair_Service.DAL;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Animation;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace Repair_Service
{
    public partial class LoginPage : Page
    {

        private LoginPageController loginPageController;

        public LoginPage()
        {
            InitializeComponent();
            loginPageController = new LoginPageController();
        }

        private void LoginWindow_Loaded(object sender, RoutedEventArgs e)
        {
            ReadUserLoginData();
        }

        private void ButtonLoginClick(object sender, RoutedEventArgs e)
        {
            SingInWithEmailAndPassword();
        }

        private async void SingInWithEmailAndPassword()
        {
            string login = TextBoxLogin.Text;
            string password = TextBoxPassword.Text;

            bool result = await loginPageController.SignInWithEmailAndPasswordAsync(login, password);
            if(result == true)
            {
                if(RememberMeCheckBox.IsChecked == true)
                await loginPageController.SaveUserDataAsync(login, password);
                MainPage mainPage = new MainPage();
                this.NavigationService.Navigate(mainPage);
            }
            else
            {
                MessageBox.Show("Error", "Error");
            }
        }

        private async void ReadUserLoginData()
        {
            List<string> userCredentials = await loginPageController.ReadUserDataAsync();
            if (userCredentials == null) return;

            TextBoxLogin.Text = userCredentials[0];
            TextBoxPassword.Text = userCredentials[1];
            RememberMeCheckBox.IsChecked = true;
        }

        private void RememberMeCheckBox_Unchecked(object sender, RoutedEventArgs e)
        {
            DeleteUserLoginData();
        }

        private async void DeleteUserLoginData()
        {
            await loginPageController.DeleteuserDataAsync();
        }

    }
}
