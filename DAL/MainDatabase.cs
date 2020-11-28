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

        public override bool AddNewBrand(Brand brand)
        {
            using (var session = NHibernateHelper.OpenSession())
            {
                using (var transaction = session.BeginTransaction())
                {
                    try
                    {
                        session.Save(brand);
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

        /// <summary>
        /// Pozwala na dodanie nowego urządzenia do bazy danych
        /// </summary>
        /// <param name="device">Obiekt klasy Device</param>
        /// <returns>Zwraca TRUE jeżeli udało się dodać urządzenie</returns>
        public override bool AddNewDevice(Device device)
        {
            using (var session = NHibernateHelper.OpenSession())
            {
                using (var transaction = session.BeginTransaction())
                {
                    try
                    {
                        session.Save(device);
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

        public override bool AddNewEmployee(Employee employee)
        {

            using (var session = NHibernateHelper.OpenSession())
            {
                using (var transaction = session.BeginTransaction())
                {
                    try
                    {
                        session.Save(employee);
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


        /// <summary>
        /// Dodawanie nowego zlecenia
        /// </summary>
        /// <param name="order">Obiekt klasy Order</param>
        public override bool AddNewOrder(Order order)
        {
            using (var session = NHibernateHelper.OpenSession())
            {
                using (var transaction = session.BeginTransaction())
                {
                    try
                    {
                        session.Save(order);
                        transaction.Commit();
                        return true;
                    }
                    catch
                    {
                        transaction.Rollback();
                        return false;
                    }
                }
            }
        }

        /// <summary>
        /// Dodawanie nowej problemy do bazy danych
        /// </summary>
        /// <param name="problem">Obiekt klasy Problem</param>
        /// <returns>Zwraca TRUE jeżeli udało się dodać nowy problem</returns>
        public override bool AddNewProblem(Problem problem)
        {
            using (var session = NHibernateHelper.OpenSession())
            {
                using (var transaction = session.BeginTransaction())
                {
                    try
                    {
                        session.Save(problem);
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

        /// <summary>
        /// Dodawanie nowego typa urządzenia do bazy danych
        /// </summary>
        /// <param name="type">Obiekt klasy Device_Type</param>
        /// <returns>Zwraca TRUE jeżeli udało się dodać nowy typ urządzeń</returns>
        public override bool AddNewType(Device_Type type)
        {
            using (var session = NHibernateHelper.OpenSession())
            {
                using (var transaction = session.BeginTransaction())
                {
                    try
                    {
                        session.Save(type);
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

        public override bool AddNewRole(Role role)
        {
            using (var session = NHibernateHelper.OpenSession())
            {
                using (var transaction = session.BeginTransaction())
                {
                    try
                    {
                        session.Save(role);
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

        public override bool AddNewSalon(Salon salon)
        {
            using (var session = NHibernateHelper.OpenSession())
            {
                using (var transaction = session.BeginTransaction())
                {
                    try
                    {
                        session.Save(salon);
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

        public override bool AddNewStatus(Status status)
        {
            using (var session = NHibernateHelper.OpenSession())
            {
                using (var transaction = session.BeginTransaction())
                {
                    try
                    {
                        session.Save(status);
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

        #region READ

        /// <summary>
        /// Zwraca listę wszystkich firm-producentów urządzeń z bazy danych
        /// </summary>
        /// <returns>Zwraca listę wszystkich firm</returns>
        public override ObservableCollection<Brand> GetBrands()
        {
            ObservableCollection<Brand> brands;
            using (var session = NHibernateHelper.OpenSession())
            {
                using (var transaction = session.BeginTransaction())
                {
                    brands = new ObservableCollection<Brand>(session.QueryOver<Brand>().List());
                    transaction.Commit();
                }
            }
            return brands;
        }

        public override ObservableCollection<Brand> GetBrandsOfType(Device_Type type)
        {
            throw new NotImplementedException();
        }

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
        /// Odczyt wszystkich urządzeń z bazy danych
        /// </summary>
        /// <returns>Zwraca listę urządzeń</returns>
        public override ObservableCollection<Device> GetDevices()
        {
            ObservableCollection<Device> devices;
            using (var session = NHibernateHelper.OpenSession())
            {
                using (var transaction = session.BeginTransaction())
                {
                    devices = new ObservableCollection<Device>(session.QueryOver<Device>().List());
                    transaction.Commit();
                }
            }
            return devices;
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
                    orders = new ObservableCollection<Order>(session.QueryOver<Order>().Cacheable().List());
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


        public override ObservableCollection<Role> GetRoles()
        {
            ObservableCollection<Role> roles;
            using (var session = NHibernateHelper.OpenSession())
            {
                using (var transaction = session.BeginTransaction())
                {
                    roles = new ObservableCollection<Role>(session.QueryOver<Role>().List());
                    transaction.Commit();
                }
            }

            return roles;
        }


        public override ObservableCollection<Salon> GetSalons()
        {
            ObservableCollection<Salon> salons;
            using (var session = NHibernateHelper.OpenSession())
            {
                using (var transaction = session.BeginTransaction())
                {
                    salons = new ObservableCollection<Salon>(session.QueryOver<Salon>().List());
                    transaction.Commit();
                }
            }

            return salons;
        }

        public override ObservableCollection<Status> GetStatuses()
        {
            ObservableCollection<Status> statuses;
            using (var session = NHibernateHelper.OpenSession())
            {
                using (var transaction = session.BeginTransaction())
                {
                    statuses = new ObservableCollection<Status>(session.QueryOver<Status>().List());
                    transaction.Commit();
                }
            }

            return statuses;
        }

        #endregion

        #region UPDATE

        /// <summary>
        /// Pozwala na aktualizacje informacji klienta w bazie danych
        /// </summary>
        /// <param name="client">Obiekt klasy Client</param>
        public override bool UpdateClient(Client client)
        {
            using (var session = NHibernateHelper.OpenSession())
            {
                using (var transaction = session.BeginTransaction())
                {
                    try
                    {
                        session.Update(client);
                        transaction.Commit();
                        return true;
                    }
                    catch 
                    {
                        transaction.Rollback();
                        return false;
                    }
                }
            } 
        }


        public override bool UpdateDevice(Device device)
        {
            using (var session = NHibernateHelper.OpenSession())
            {
                using (var transaction = session.BeginTransaction())
                {
                    try
                    {
                        session.Update(device);
                        transaction.Commit();
                        return true;
                    }
                    catch
                    {
                        transaction.Rollback();
                        return false;
                    }
                }
            }
        }


        public override bool UpdateType(Device_Type type)
        {
            using (var session = NHibernateHelper.OpenSession())
            {
                using (var transaction = session.BeginTransaction())
                {
                    try
                    {
                        session.Update(type);
                        transaction.Commit();
                        return true;
                    }
                    catch
                    {
                        transaction.Rollback();
                        return false;
                    }
                }
            }
        }


        public override bool UpdateBrand(Brand brand)
        {
            using (var session = NHibernateHelper.OpenSession())
            {
                using (var transaction = session.BeginTransaction())
                {
                    try
                    {
                        session.Update(brand);
                        transaction.Commit();
                        return true;
                    }
                    catch
                    {
                        transaction.Rollback();
                        return false;
                    }
                }
            }
        }


        public override bool UpdateEmployee(Employee employee)
        {
            using (var session = NHibernateHelper.OpenSession())
            {
                using (var transaction = session.BeginTransaction())
                {
                    try
                    {
                        session.Update(employee);
                        transaction.Commit();
                        return true;
                    }
                    catch
                    {
                        transaction.Rollback();
                        return false;
                    }
                }
            }
        }


        public override bool UpdateRole(Role role)
        {
            using (var session = NHibernateHelper.OpenSession())
            {
                using (var transaction = session.BeginTransaction())
                {
                    try
                    {
                        session.Update(role);
                        transaction.Commit();
                        return true;
                    }
                    catch
                    {
                        transaction.Rollback();
                        return false;
                    }
                }
            }
        }


        public override bool UpdateSalon(Salon salon)
        {
            using (var session = NHibernateHelper.OpenSession())
            {
                using (var transaction = session.BeginTransaction())
                {
                    try
                    {
                        session.Update(salon);
                        transaction.Commit();
                        return true;
                    }
                    catch
                    {
                        transaction.Rollback();
                        return false;
                    }
                }
            }
        }


        public override bool UpdateStatus(Status status)
        {
            using (var session = NHibernateHelper.OpenSession())
            {
                using (var transaction = session.BeginTransaction())
                {
                    try
                    {
                        session.Update(status);
                        transaction.Commit();
                        return true;
                    }
                    catch
                    {
                        transaction.Rollback();
                        return false;
                    }
                }
            }
        }


        public override bool UpdateProblem(Problem problem)
        {
            using (var session = NHibernateHelper.OpenSession())
            {
                using (var transaction = session.BeginTransaction())
                {
                    try
                    {
                        session.Update(problem);
                        transaction.Commit();
                        return true;
                    }
                    catch
                    {
                        transaction.Rollback();
                        return false;
                    }
                }
            }
        }
        #endregion

        #region DELETE

        public override bool DeleteBrand(Brand brand)
        {
            using (var session = NHibernateHelper.OpenSession())
            {
                using (var transaction = session.BeginTransaction())
                {
                    try
                    {
                        session.Delete(brand);
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

        /// <summary>
        /// Pozwala na usunięcie urządzenia z bazy danych
        /// </summary>
        /// <param name="device">Obiekt klasy Device</param>
        /// <returns>Zwraca TRUE jeżeli udało się usunąć urządzenie</returns>
        public override bool DeleteDevice(Device device)
        {
            using (var session = NHibernateHelper.OpenSession())
            {
                using (var transaction = session.BeginTransaction())
                {
                    try
                    {
                        session.Delete(device);
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

        /// <summary>
        /// Pozwala na usunięcie typu urządzeń z bazy danych
        /// </summary>
        /// <param name="type">Obiekt klasy Device_Type</param>
        /// <returns>Zwraca TRUE jeżeli udało się usunąć</returns>
        public override bool DeleteType(Device_Type type)
        {
            using (var session = NHibernateHelper.OpenSession())
            {
                using (var transaction = session.BeginTransaction())
                {
                    try
                    {
                        session.Delete(type);
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

        /// <summary>
        /// Pozwala na usunięcie pracownika z bazy danych
        /// </summary>
        /// <param name="employee">Obiekt klasy Employee</param>
        /// <returns>Zwraca TRUE jeżeli udało się usunąć pracownika</returns>
        public override bool DeleteEmployee(Employee employee)
        {
            using (var session = NHibernateHelper.OpenSession())
            {
                using (var transaction = session.BeginTransaction())
                {
                    try
                    {
                        session.Delete(employee);
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


        public override bool DeleteProblem(Problem problem)
        {
            using (var session = NHibernateHelper.OpenSession())
            {
                using (var transaction = session.BeginTransaction())
                {
                    try
                    {
                        session.Delete(problem);
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

        public override bool DeleteRole(Role role)
        {
            using (var session = NHibernateHelper.OpenSession())
            {
                using (var transaction = session.BeginTransaction())
                {
                    try
                    {
                        session.Delete(role);
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


        public override bool DeleteSalon(Salon salon)
        {
            using (var session = NHibernateHelper.OpenSession())
            {
                using (var transaction = session.BeginTransaction())
                {
                    try
                    {
                        session.Delete(salon);
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



        public override bool DeleteStatus(Status status)
        {
            using (var session = NHibernateHelper.OpenSession())
            {
                using (var transaction = session.BeginTransaction())
                {
                    try
                    {
                        session.Delete(status);
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
