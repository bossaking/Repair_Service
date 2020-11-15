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


        #region CLIENTS TABLE
        public abstract void AddNewClient(Client client);
        public abstract ObservableCollection<Client> GetAllClients();
        #endregion

        #region DEVICES TYPES TABLE
        public abstract ObservableCollection<Device_Type> GetTypes();
        #endregion

        #region EMPLOYEES TABLE
        public abstract ObservableCollection<Employee> GetEmployees();
        #endregion

        #region ORDERS TABLE
        public abstract void AddNewOrder(Order order);
        public abstract ObservableCollection<Order> GetAllOrders();
        public abstract void DeleteOrder(int id);
        #endregion

        #region PROBLEMS TABLE
        public abstract ObservableCollection<Problem> GetProblems();

        #endregion



        public abstract bool SingInWithLoginAndPassword(string login, string password);
        

    }
}
