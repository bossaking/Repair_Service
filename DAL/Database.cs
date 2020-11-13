using Repair_Service.Models;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repair_Service.DAL
{
    public abstract class Database
    {
        public abstract ObservableCollection<Order> GetAllOrders();
        public abstract bool SingInWithLoginAndPassword(string login, string password);

    }
}
