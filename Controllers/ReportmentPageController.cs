using Repair_Service.DAL;
using Repair_Service.Models;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repair_Service.Controllers
{
    public class ReportmentPageController
    {

        private Database database;

        public ReportmentPageController()
        {
            database = ProxyDatabase.GetDatabase();
        }
        

        public async Task<ObservableCollection<Employee>> GetEmployeesAsync()
        {
            ObservableCollection<Employee> employees = new ObservableCollection<Employee>();

            await Task.Run(() => 
                employees = database.GetEmployees()
            );

            return employees;
        }
        public async Task<ObservableCollection<Client>> GetClientsAsync()
        {
            ObservableCollection<Client> clients = new ObservableCollection<Client>();
            await Task.Run(() => 
                clients = database.GetAllClients()
            );

            return clients;
        }

        public async Task<ObservableCollection<Device_Type>> GetTypesAsync()
        {
            ObservableCollection<Device_Type> types = new ObservableCollection<Device_Type>();

            await Task.Run(() =>
                types = database.GetTypes()
            );

            return types;
        }

        public async void AddNewOrder(Order order)
        {
            await Task.Run(() => 
                database.AddNewOrder(order)
            );
        }

        public Order GetNewOrder()
        {
            return new Order();
        }
    }
}
