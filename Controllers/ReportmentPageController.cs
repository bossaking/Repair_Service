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
    public class ReportmentPageController : PageController
    {
        public ReportmentPageController() : base() { }
        

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

        public ObservableCollection<Brand> GetBrandsofType(Device_Type type)
        {
            return database.GetBrandsOfType(type);
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

        public async Task<ObservableCollection<Status>> GetStatusesAsync()
        {
            return await Task.Run(() => database.GetStatuses());
        }

        public async Task<bool> AddNewOrder(Order order)
        {
            return await Task.Run(() => 
                database.AddNewOrder(order)
            );
        }

        public async Task<bool> UpdateOrderAsync(Order order)
        {
            return await Task.Run(() => database.UpdateOrder(order));
        }

        public Order GetNewOrder()
        {
            return new Order();
        }
    }
}
