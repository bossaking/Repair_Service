using Repair_Service.Models;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repair_Service.Controllers
{
    public class ArchivePageController : PageController
    {

        public ArchivePageController() : base() { }

        public async Task<ObservableCollection<Order>> GetOrdersAsync()
        {
            return await Task.Run(() => database.GetArchiveOrders());
        }

        public async void RestoreOrder(Order order)
        {
            await Task.Run(() => database.RestoreOrder(order));
        }

    }
}
