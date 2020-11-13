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
        private ObservableCollection<Order> orders;

        private static ProxyDatabase instance;

        private ProxyDatabase()
        {
        }

        public static ProxyDatabase GetDatabase()
        {
            if (instance == null) instance = new ProxyDatabase();
            return instance;
        }

        public override void DeleteOrder(int id)
        {
            System.Windows.Application.Current.Dispatcher.Invoke(() => orders.Remove(orders.Where(o => o.Id_Order == id).FirstOrDefault()));
            database.DeleteOrder(id);
        }

        public override ObservableCollection<Order> GetAllOrders()
        {
            if(orders == null)
            {
                orders = database == null ? (database = new MainDatabase()).GetAllOrders() : database.GetAllOrders();
            }

            return orders;
        }

        public override bool SingInWithLoginAndPassword(string login, string password)
        {
            if(database == null) database = new MainDatabase();
            return database.SingInWithLoginAndPassword(login, password);
        }
    }
}
