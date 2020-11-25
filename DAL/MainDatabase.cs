using NHibernate;
using Repair_Service.Models;
using Repair_Service.NHibernate;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace Repair_Service.DAL
{
    public class MainDatabase : Database
    {

        /// <summary>
        /// Metoda, pozwalająca na sprawdzenie połączenia z bazą danych
        /// </summary>
        /// <returns>Zwraca TRUE w przypadku, gdy udało się otworzyć sesje. W przeciwnym przypadku zwraca FALSE</returns>
        public bool CheckConnection()
        {
            try
            {
                ISession session = NHibernateHelper.OpenSession();
                session.Close();
                return true;
            }
            catch
            {
                return false;
            }
        }

        #region CRUD's

        #region CREATE

        /// <summary>
        /// Dodawanie nowego zlecenia
        /// </summary>
        /// <param name="order">Obiekt klasy Order</param>
        public override void AddNewOrder(Order order)
        {
            using(var session = NHibernateHelper.OpenSession())
            {
                using(var transaction = session.BeginTransaction())
                {
                    IList<Problem> problems = session.QueryOver<Problem>().List();
                    //TODO Obsłużyć wszystkie wyjątki
                    order.Problems = problems;

                    session.Save(order);
                    transaction.Commit();
                }
            }
        }

        /// <summary>
        /// Dodawanie nowego klienta
        /// </summary>
        /// <param name="client">Obiekt klasy Client</param>
        public override void AddNewClient(Client client)
        {
            using (var session = NHibernateHelper.OpenSession())
            {
                using (var transaction = session.BeginTransaction())
                {
                    //TODO Obsłużyć wszystkie wyjątki
                    session.Save(client);
                    transaction.Commit();
                }
            }
        }


        #endregion

        #region READ

        /// <summary>
        /// Odczyt wszystkich klientów z bazy danych
        /// </summary>
        /// <returns>Zwraca listę klientów</returns>
        public override ObservableCollection<Client> GetAllClients()
        {

            ObservableCollection<Client> clients = new ObservableCollection<Client>();
            using (var session = NHibernateHelper.OpenSession())
            {
                using (var transaction = session.BeginTransaction())
                {
                    clients = new ObservableCollection<Client>(session.QueryOver<Client>().List());
                    transaction.Commit();
                }
            }

            return clients;
        }

        /// <summary>
        /// Odczyt wszystkich zleceń z bazy danych
        /// </summary>
        /// <returns>Zwraca listę zleceń</returns>
        public override ObservableCollection<Order> GetAllOrders()
        {

            ObservableCollection<Order> orders;
            using (var session = NHibernateHelper.OpenSession())
            {
                using (var transaction = session.BeginTransaction())
                {
                    orders = new ObservableCollection<Order>(session.QueryOver<Order>().List());
                    transaction.Commit();
                }
            }

            return orders;
        }

        /// <summary>
        /// Odczyt fszystkich pracowników z bazy danych
        /// </summary>
        /// <returns>Zwraca listę pracowników</returns>
        public override ObservableCollection<Employee> GetEmployees()
        {
            ObservableCollection<Employee> employees;
            using (var session = NHibernateHelper.OpenSession())
            {
                using (var transaction = session.BeginTransaction())
                {
                    employees = new ObservableCollection<Employee>(session.QueryOver<Employee>().List());
                    transaction.Commit();
                }
            }

            return employees;
        }

        /// <summary>
        /// Odczyt wszystkich typów urządzeń z bazy danych
        /// </summary>
        /// <returns>Zwraca listę typów urządzeń</returns>
        public override ObservableCollection<Device_Type> GetTypes()
        {
            ObservableCollection<Device_Type> types;
            using (var session = NHibernateHelper.OpenSession())
            {
                using (var transaction = session.BeginTransaction())
                {
                    types = new ObservableCollection<Device_Type>(session.QueryOver<Device_Type>().List());
                    transaction.Commit();
                }
            }

            return types;
        }

        /// <summary>
        /// Odczyt wszystkich problemów z bazy danych
        /// </summary>
        /// <returns>Zwraca listę wszyskich problemów</returns>
        public override ObservableCollection<Problem> GetProblems()
        {
            ObservableCollection<Problem> problems;
            using (var session = NHibernateHelper.OpenSession())
            {
                using (var transaction = session.BeginTransaction())
                {
                    problems = new ObservableCollection<Problem>(session.QueryOver<Problem>().List());
                    transaction.Commit();
                }
            }

            return problems;
        }

        #endregion

        #region UPDATE

        /// <summary>
        /// Pozwala na aktualizacje informacji klienta w bazie danych
        /// </summary>
        /// <param name="client">Obiekt klasy Client</param>
        public override void UpdateClient(Client client)
        {
            using (var session = NHibernateHelper.OpenSession())
            {
                using (var transaction = session.BeginTransaction())
                {
                    session.Update(client);
                    transaction.Commit();
                }
            }
        }

        #endregion


        #region DELETE

        /// <summary>
        /// Usuwanie zlecenia o podanym ID z bazy danych
        /// </summary>
        /// <param name="id">ID zlecenia</param>
        public override void DeleteOrder(int id)
        {
            using (var session = NHibernateHelper.OpenSession())
            {
                using (var transaction = session.BeginTransaction())
                {
                    Order order = session.QueryOver<Order>().Where(o => o.Id_Order == id).SingleOrDefault();
                    session.Delete(order);
                    transaction.Commit();
                    //TODO EXCEPTIONS
                }
            }
        }

        /// <summary>
        /// Usuwanie klienta o podanym ID z bazy danych
        /// </summary>
        /// <param name="id">Id klienta</param>
        /// <returns>Zwraca TRUE jeżeli udało się usunąć klienta</returns>
        public override bool DeleteClient(int id)
        {
            using (var session = NHibernateHelper.OpenSession())
            {
                using (var transaction = session.BeginTransaction())
                {
                    try
                    {
                        Client client = session.QueryOver<Client>().Where(o => o.Id_Client == id).SingleOrDefault();
                        session.Delete(client);
                        transaction.Commit();
                        return true;
                    }
                    catch
                    {
                        return false;
                    }
                }
            }
        }

        #endregion
        #endregion


        /// <summary>
        /// Metoda, pozwalająca na logowanie za pomocą logina i hasła
        /// </summary>
        /// <param name="login">Login użytkownika</param>
        /// <param name="password">Hasło użytkownika</param>
        /// <returns>Zwraca TRUE jeżeli udało się zalogować</returns>
        public override bool SingInWithLoginAndPassword(string login, string password)
        {
            bool result = false;

            using (var session = NHibernateHelper.OpenSession())
            {

                using (var transaction = session.BeginTransaction())
                {
                    Employee employee = session.QueryOver<Employee>().Where(e => e.Login == login).SingleOrDefault();
                    if (employee == null) { result = false; }
                    else if (employee.Passwd == password) { result = true; }
                    transaction.Commit();
                }
            }

            return result;
        }
    }
}
