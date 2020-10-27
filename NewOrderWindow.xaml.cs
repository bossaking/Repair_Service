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
using Repair_Service.DAL;
using Repair_Service.Models;
using Type = Repair_Service.Models.Type;

namespace Repair_Service
{
    public partial class NewOrderWindow : Window
    {

        OrdersManager ordersManager;

        public NewOrderWindow(OrdersManager ordersManager)
        {
            InitializeComponent();
            this.ordersManager = ordersManager;
        }

        private void addNewOrderButton_Click(object sender, RoutedEventArgs e)
        {
            int startPrice;

            try
            {
                startPrice = int.Parse(startPriceText.Text);
            }
            catch
            {
                return;
            }

            ordersManager.AddNewOrder(mainProblemText.Text, phoneNumberText.Text, ownerNameText.Text, startPrice, (Type)typesComboBox.SelectedItem);
            Close();
        }
    }
}
