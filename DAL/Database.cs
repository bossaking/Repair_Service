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
        public abstract void AddNewOrder(Order order);
        public abstract ObservableCollection<Order> GetAllOrders();
        public abstract void DeleteOrder(int id);

        public abstract void AddNewClient(Client client);
        public abstract ObservableCollection<Client> GetAllClients();



        public abstract ObservableCollection<Employee> GetEmployees();


        public abstract ObservableCollection<Device_Type> GetTypes();







        public abstract bool SingInWithLoginAndPassword(string login, string password);
        

    }
}
