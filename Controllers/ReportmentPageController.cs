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

        /// <summary>
        /// Pozwala na asynchroniczny odczyt wszystkich pracowników
        /// </summary>
        /// <returns>Zwraca listę wszystkich pracowników</returns>
        public async Task<ObservableCollection<Employee>> GetEmployeesAsync()
        {
            ObservableCollection<Employee> employees = new ObservableCollection<Employee>();

            await Task.Run(() => 
                employees = database.GetEmployees()
            );

            return employees;
        }

        /// <summary>
        /// Pozwala na asynchroniczny odczyt wszystkich klientów
        /// </summary>
        /// <returns>Zwraca listę wszystkich klientów</returns>
        public async Task<ObservableCollection<Client>> GetClientsAsync()
        {
            ObservableCollection<Client> clients = new ObservableCollection<Client>();
            await Task.Run(() => 
                clients = database.GetAllClients()
            );

            return clients;
        }

        /// <summary>
        /// Pozwala na asynchroniczny odczyt wszystkich typów urządzeń
        /// </summary>
        /// <returns>Zwraca listę wszystkich typów urządzeń</returns>
        public async Task<ObservableCollection<Device_Type>> GetTypesAsync()
        {
            ObservableCollection<Device_Type> types = new ObservableCollection<Device_Type>();

            await Task.Run(() =>
                types = database.GetTypes()
            );

            return types;
        }

        /// <summary>
        /// Pozwala na asynchroniczny odczyt wszystkich problemów
        /// </summary>
        /// <returns>Zwraca listę wszystkich problemów</returns>
        public async Task<ObservableCollection<Problem>> GetProblemsAsync()
        {
            ObservableCollection<Problem> problems = new ObservableCollection<Problem>();
            await Task.Run(() => 
                problems = database.GetProblems()
            );
            return problems;
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
