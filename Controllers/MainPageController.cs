using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Repair_Service.DAL;
using Repair_Service.Models;

namespace Repair_Service.Controllers
{
    public class MainPageController : PageController
    {


        public MainPageController() : base() { }


        /// <summary>
        /// Metoda, pozwalająca na asynchroniczne pobieranie wszystkich zleceń z bazy danych
        /// </summary>
        public async Task<ObservableCollection<Order>> GetAllOrdersAsync()
        {
            ObservableCollection<Order> orders = new ObservableCollection<Order>();

            await Task.Run(() => 
                orders = database.GetAllOrders()
            );

            return orders;
        }
        
        public async Task<bool> RefreshOrders()
        {
            return await Task.Run(() => (database as ProxyDatabase).RefreshOrders());
        }


    }
}
