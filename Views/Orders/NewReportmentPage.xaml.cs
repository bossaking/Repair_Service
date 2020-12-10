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
    public partial class NewReportmentPage : Page
    {
        private ReportmentPageController reportmentPageController;
        private Order newOrder;
        MainWindow window;

        private IList<Problem> problems;

        public NewReportmentPage()
        {
            InitializeComponent();
        }

        #region DATA
        private void NewReportmentPage_Loaded(object sender, RoutedEventArgs e)
        {
            window = (MainWindow)Application.Current.MainWindow;
            window.Title = "Repair Service: New order";

            DeviceTypeComboBox.SelectionChanged += DeviceTypeComboBox_SelectionChanged;
            DeviceBrandComboBox.SelectionChanged += DeviceBrandComboBox_SelectionChanged;
            var dpd = DependencyPropertyDescriptor.FromProperty(ItemsControl.ItemsSourceProperty, typeof(ComboBox));
            if (dpd != null)
            {
                dpd.AddValueChanged(DeviceModelComboBox, ModelsComboBoxItemSourceChanged);
            }
            ProblemsComboBox.SelectedItemsChanged += ProblemsComboBox_SelectedItemsChanged;

            reportmentPageController = new ReportmentPageController();
            newOrder = reportmentPageController.GetNewOrder();

            DataContext = newOrder;

            GetEmployees();
            GetTypes();
            GetProblems();

            problems = new List<Problem>();
        }

        private void ProblemsComboBox_SelectedItemsChanged(object sender, Sdl.MultiSelectComboBox.EventArgs.SelectedItemsChangedEventArgs e)
        {
            if (e.Added.Count > 0)
                problems.Add((e.Added as IList)[0] as Problem);

            if (e.Removed.Count > 0)
                problems.Remove((e.Removed as IList)[0] as Problem);
        }

        /// <summary>
        /// Pobiera i przypisuje dane do elementu EmployeesComboBox
        /// </summary>
        private async void GetEmployees()
        {
            EmployeesComboBox.ItemsSource = await reportmentPageController.GetEmployeesAsync();
        }

        /// <summary>
        /// Pobiera i przypisuje dane do elementu DeviceTypeComboBox
        /// </summary>
        private async void GetTypes()
        {
            DeviceTypeComboBox.ItemsSource = await reportmentPageController.GetTypesAsync();
        }

        /// <summary>
        /// Pobiera i przypisuje dane do elementu ProblemsAutoComplete
        /// </summary>
        private async void GetProblems()
        {
            ProblemsComboBox.ItemsSource = await reportmentPageController.GetProblemsAsync();
        }

        private void DeviceTypeComboBox_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            if (DeviceTypeComboBox.SelectedItem != null)
            {
                DeviceBrandComboBox.ItemsSource = reportmentPageController.GetBrandsofType(DeviceTypeComboBox.SelectedItem as Device_Type);
                DeviceBrandComboBox.IsEnabled = true;
                DeviceBrandComboBox.SelectedIndex = 0;
            }
        }

        private void DeviceBrandComboBox_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            if (DeviceBrandComboBox.SelectedItem != null)
            {
                DeviceModelComboBox.ItemsSource = reportmentPageController.GetDevicesOfTypeAndBrand(DeviceTypeComboBox.SelectedItem as Device_Type,
                    DeviceBrandComboBox.SelectedItem as Brand);
                DeviceModelComboBox.IsEnabled = true;
                DeviceModelComboBox.SelectedIndex = 0;

            }
        }

        private void ModelsComboBoxItemSourceChanged(object sender, EventArgs e)
        {
            if (DeviceModelComboBox.Items.Count == 0)
            {
                DeviceModelComboBox.IsEnabled = false;
            }
        }

        private async void AddNewOrder()
        {

            newOrder.Problems = problems;
            window.ShowProgressBar();
            if (!await reportmentPageController.AddNewOrder(newOrder))
            {
                //MessageBox.Show("Something went wrong...Try again", "Error", MessageBoxButton.OK, MessageBoxImage.Error);

                ErrorWindow errorWindow = new ErrorWindow
                {
                    Owner = window
                };

                errorWindow.text = "Something went wrong...Try again";
                errorWindow.ShowDialog();

                EnableGrid();
                window.HideProgressBar();
                return;
            }
            LoadMainPage();
        }
        #endregion

        #region BUTTONS
        private void SelectClientButton_Click(object sender, RoutedEventArgs e)
        {
            ChooseExisitingClientWindow chooseExisitingClientWindow = new ChooseExisitingClientWindow { Owner = Window.GetWindow(this) };
            if (chooseExisitingClientWindow.ShowDialog() == true)
            {
                Client client = new Client
                {
                    Name = chooseExisitingClientWindow.client.Name,
                    Surname = chooseExisitingClientWindow.client.Surname,
                    Phone_Number = chooseExisitingClientWindow.client.Phone_Number
                };
                newOrder.Client = client;
            }
            DataContext = null;
            DataContext = newOrder;
        }

        private void AddButton_Click(object sender, RoutedEventArgs e)
        {
            if (Validator.HasErrors(MainGrid)) return;
            DisableGrid();
            AddNewOrder();
        }



        private void CancelButton_Click(object sender, RoutedEventArgs e)
        {
            LoadMainPage();
        }

        private void LoadMainPage()
        {
            MainPage mainPage = new MainPage();
            this.NavigationService.Navigate(mainPage);
        }

        private void DisableGrid()
        {
            MainGrid.IsEnabled = false;
        }

        private void EnableGrid()
        {
            MainGrid.IsEnabled = true;
        }
        #endregion
    }
}