using Repair_Service.Models;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repair_Service.DAL
{
    public class ProxyDatabase : Database
    {

        private MainDatabase database;

        public override ObservableCollection<Order> GetAllOrders()
        {
            throw new NotImplementedException();
        }
    }
}
