using Repair_Service.Controllers;
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
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace Repair_Service
{
    public partial class AddEditProblemsPage : Page
    {
        ProblemsPageController pageController;
        Problem problem;
        Modes mode;

        public AddEditProblemsPage(ProblemsPageController pageController, Problem problem, Modes mode)
        {
            this.pageController = pageController;
            this.problem = problem;
            this.mode = mode;
            DataContext = problem;
            InitializeComponent();
        }

        private async void AddNewProblem()
        {
            if(! await pageController.AddNewProblemAsync(problem))
            {
                //TODO Zmienić komunikat
                MessageBox.Show("Jakiś tam error", "Error", MessageBoxButton.OK, MessageBoxImage.Error);
                return;
            }
            LoadProblemsPage();
        }

        #region BUTTONS
        private void OkButton_Click(object sender, RoutedEventArgs e)
        {
            if(mode == Modes.Add)
            AddNewProblem();

        }

        private void CancelButton_Click(object sender, RoutedEventArgs e)
        {
            LoadProblemsPage();
        }

        private void LoadProblemsPage()
        {
            ProblemsPage problemsPage = new ProblemsPage();
            this.NavigationService.Navigate(problemsPage);
        }
        #endregion
    }
}
