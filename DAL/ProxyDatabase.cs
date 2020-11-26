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

        MainDatabase database;
        ObservableCollection<Order> orders;
        ObservableCollection<Client> clients;
        ObservableCollection<Employee> employees;
        ObservableCollection<Device_Type> types;
        ObservableCollection<Problem> problems;

        private static ProxyDatabase instance;

        private ProxyDatabase()
        {
        }

        public static ProxyDatabase GetDatabase()
        {
            if (instance == null) instance = new ProxyDatabase();
            return instance;
        }



        #region CLIENTS TABLE

        /// <summary>
        /// Zwraca listę wszystkich klientów
        /// </summary>
        /// <returns>Zwraca listę wszystkich klientów</returns>
        public override ObservableCollection<Client> GetAllClients()
        {
            if (clients == null)
            {
                clients = database == null ? (database = new MainDatabase()).GetAllClients() : database.GetAllClients();
            }

            return clients;
        }

        /// <summary>
        /// Pozwala na dodawanie nowego klienta do bazy danych
        /// </summary>
        /// <param name="client">Obiekt klasy Client</param>
        public override void AddNewClient(Client client)
        {
            if (!ClientExists(client))
            {
                App.Current.Dispatcher.Invoke(() => clients.Add(client));
                database.AddNewClient(client);
            }
        }

        /// <summary>
        /// Pozwala na aktualizacje infirmacji klienta w bazie danych 
        /// </summary>
        /// <param name="client">Obiekt klasy Client</param>
        public override void UpdateClient(Client client)
        {
            Client oldClient = clients.First(c => c.Id_Client == client.Id_Client);
            oldClient = client;
            database.UpdateClient(client);
        }

        /// <summary>
        /// Pozwala na usunięcie klienta z bazy danych
        /// </summary>
        /// <param name="id">Id klienta</param>
        /// <returns>Zwraca TRUE jeżeli udało się usunąć klienta</returns>
        public override bool DeleteClient(int id)
        {
            bool result = database.DeleteClient(id);
            if (result == true) 
            App.Current.Dispatcher.Invoke(() => clients.Remove(clients.Where(o => o.Id_Client == id).FirstOrDefault()));
            return result;
        }

        /// <summary>
        /// Pozwala sprawdzić czy podany klient już znajduje się w bazie danych
        /// </summary>
        /// <param name="client">Obiekt klasy Client</param>
        /// <returns>Zwraca TRUE jeżeli dany klient już znajduje się w bazie</returns>
        private bool ClientExists(Client client)
        {
            if (clients == null) GetAllClients();
            Client repeatClient = clients.Where(c => c.Name == client.Name && c.Surname == client.Surname && c.Phone_Number == c.Phone_Number).FirstOrDefault();
            return repeatClient != null;
        }

        /// <summary>
        /// Pozwala odnaleźć klienta na liście i zwraca jego identyfikator
        /// </summary>
        /// <param name="client">Obiekt klasy Client</param>
        /// <returns>Zwraca ID klienta</returns>
        private int GetClientId(Client client)
        {
            Client reClient = clients.Where(c => c.Name == client.Name && c.Surname == client.Surname && c.Phone_Number == c.Phone_Number).FirstOrDefault();
            return reClient.Id_Client;
        }

        #endregion

        #region DEVICES TYPES TABLE
        public override ObservableCollection<Device_Type> GetTypes()
        {
            if (types == null)
            {
                types = database == null ? (database = new MainDatabase()).GetTypes() : database.GetTypes();
            }

            return types;
        }
        #endregion

        #region EMPLOYEES TABLE
        public override ObservableCollection<Employee> GetEmployees()
        {
            if (employees == null)
            {
                employees = database == null ? (database = new MainDatabase()).GetEmployees() : database.GetEmployees();
            }

            return employees;
        }
        #endregion

        #region ORDERS TABLE
        public override void AddNewOrder(Order order)
        {

            if (database == null)
            {
                database = new MainDatabase();
            }


            AddNewClient(order.Client);
            order.Client.Id_Client = GetClientId(order.Client);
            database.AddNewOrder(order);
            App.Current.Dispatcher.Invoke(() => orders.Add(order));
        }

        /// <summary>
        /// Zwraca listę wszystkich zleceń
        /// </summary>
        /// <returns>Lista wszystkich zleceń</returns>
        public override ObservableCollection<Order> GetAllOrders()
        {
            if (orders == null)
            {
                orders = database == null ? (database = new MainDatabase()).GetAllOrders() : database.GetAllOrders();
            }

            return orders;
        }

        public override void DeleteOrder(int id)
        {
            App.Current.Dispatcher.Invoke(() => orders.Remove(orders.Where(o => o.Id_Order == id).FirstOrDefault()));
            database.DeleteOrder(id);
        }

        #endregion

        #region PROBLEMS TABLE

        public override ObservableCollection<Problem> GetProblems()
        {
            if (problems == null)
            {
                problems = database == null ? (database = new MainDatabase()).GetProblems() : database.GetProblems();
            }

            return problems;
        }

        #endregion










        public override bool SingInWithLoginAndPassword(string login, string password)
        {
            if (database == null) database = new MainDatabase();
            return database.SingInWithLoginAndPassword(login, password);
        }



    }
}
