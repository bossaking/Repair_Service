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
    //TODO Dodać edycje
    //TODO Dodać Progress Bar
    public partial class ProblemsPage : Page
    {
        ProblemsPageController pageController;
        public ProblemsPage()
        {
            InitializeComponent();
            this.Loaded += ProblemsPage_Loaded;
            pageController = new ProblemsPageController();
        }

        private void ProblemsPage_Loaded(object sender, RoutedEventArgs e)
        {
            LoadProblems();
        }

        private async void LoadProblems()
        {
            DataGrid.ItemsSource = await pageController.GetProblemsAsync();
        }

        private async void DeleteProblem()
        {
            if(! await pageController.DeleteProblemAsync(DataGrid.SelectedItem as Problem))
            {
                MessageBox.Show("Selected item cannot be deleted!", "Delete error", MessageBoxButton.OK, MessageBoxImage.Error);
            }
        }

        #region PROGRESS BAR

        private void ShowProgressBar()
        {
            ProgressBar.Visibility = Visibility.Visible;
        }

        private void HideProgressBar()
        {
            ProgressBar.Visibility = Visibility.Hidden;
        }

        private void RefreshButton_Click(object sender, RoutedEventArgs e)
        {

        }

        #endregion

        #region BUTTONS


        private void DeleteButton_Click(object sender, RoutedEventArgs e)
        {
            if (MessageBox.Show("Are you sure you want to remove the selected problem?", "Delete problem",
                MessageBoxButton.YesNo, MessageBoxImage.Question) != MessageBoxResult.Yes)
            {
                return;
            }
            else
            {
                DeleteProblem();
            }
        }

        private void AddButton_Click(object sender, RoutedEventArgs e)
        {
            AddEditProblemsPage addEditProblemPage = new AddEditProblemsPage(pageController, new Problem(), Modes.Add);
            this.NavigationService.Navigate(addEditProblemPage);
        }

        private void EditButton_Click(object sender, RoutedEventArgs e)
        {
            Problem problem = new Problem
            {
                Id_Problem = (DataGrid.SelectedItem as Problem).Id_Problem,
                Title = (DataGrid.SelectedItem as Problem).Title,
                Orders = (DataGrid.SelectedItem as Problem).Orders
            };
            AddEditProblemsPage addEditProblemPage = new AddEditProblemsPage(pageController, problem, Modes.Edit);
            this.NavigationService.Navigate(addEditProblemPage);
        }

        private void BackButton_Click(object sender, RoutedEventArgs e)
        {
            MainPage mainPage = new MainPage();
            this.NavigationService.Navigate(mainPage);
        }


        #endregion
    }
}
