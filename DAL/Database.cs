using NHibernate;
using Repair_Service.Models;
using Repair_Service.NHibernate;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace Repair_Service.DAL
{
    public class Database
    {

        public void CheckConnection()
        {
            try
            {
                ISession session = NHibernateHelper.OpenSession();
                MessageBox.Show($"Version: {session.Connection.DataSource}", "Connection opened");
                
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message, "Connection error");
            }
        }

        #region CRUD's

        #region CREATE

        /// <summary>
        /// Dodawanie do bazy nowego klienta
        /// </summary>
        public void AddNewClient()
        {
            using (var session = NHibernateHelper.OpenSession())
            {
                using (var transaction = session.BeginTransaction())
                {
                    Client client = new Client { Name = "Mateusz", Surname = "Czajkowski", Phone_Number = "+48111222333" };
                    session.Save(client);
                    transaction.Commit();
                    MessageBox.Show("New client added");
                }
            }
        }

        /// <summary>
        /// Dodawanie do bazy nowej firmy producenta
        /// </summary>
        public void AddNewBrand()
        {
            using (var session = NHibernateHelper.OpenSession())
            {
                using (var transaction = session.BeginTransaction())
                {
                    Brand brand = new Brand { Title = "Samsung" };
                    session.Save(brand);
                    transaction.Commit();
                    MessageBox.Show($"New brand added");
                }
            }
        }

        /// <summary>
        /// Dodawanie do bazy nowego typu urządzenia
        /// </summary>
        public void AddNewType()
        {
            using (var session = NHibernateHelper.OpenSession())
            {
                using (var transaction = session.BeginTransaction())
                {
                    Device_Type device_Type = new Device_Type { Type_Title = "Mobile phone" };

                    session.Save(device_Type);
                    transaction.Commit();
                    MessageBox.Show("New device type added!");
                }
            }
        }

        /// <summary>
        /// Dodawanie do bazy nowego problemu
        /// </summary>
        public void AddNewProblem()
        {
            using (var session = NHibernateHelper.OpenSession())
            {
                using (var transaction = session.BeginTransaction())
                {
                    Problem problem = new Problem { Title = "Nie włącza się" };
                    session.Save(problem);
                    transaction.Commit();
                    MessageBox.Show("New problem added");
                }
            }
        }

        /// <summary>
        /// Dodawanie do bazy nowego typu
        /// </summary>
        public void AddNewRole()
        {
            using (var session = NHibernateHelper.OpenSession())
            {
                using (var transaction = session.BeginTransaction())
                {
                    Role role = new Role { Title = "Administrator" };
                    session.Save(role);
                    transaction.Commit();
                    MessageBox.Show("New role added");
                }
            }
        }

        /// <summary>
        /// Dodawanie do bazy nowego salonu
        /// </summary>
        public void AddNewSalon()
        {
            using (var session = NHibernateHelper.OpenSession())
            {
                using (var transaction = session.BeginTransaction())
                {
                    Salon salon = new Salon { Title = "Title", Location = "Zwierzyniecka 12" };
                    session.Save(salon);
                    transaction.Commit();
                    MessageBox.Show("New salon added");
                }
            }
        }

        /// <summary>
        /// Dodawanie do bazy nowego urządzenia
        /// </summary>
        public void AddNewDevice()
        {
            using (var session = NHibernateHelper.OpenSession())
            {
                using (var transaction = session.BeginTransaction())
                {
                    Brand brand = session.QueryOver<Brand>().Where(b => b.Id_Brand == 1).SingleOrDefault();
                    Device_Type device_Type = session.QueryOver<Device_Type>().Where(dt => dt.Id_Type == 1).SingleOrDefault();
                    Device device = new Device { Model_Title = "Galaxy S7", Device_Brand = brand, Device_Type = device_Type };

                    session.Save(device);
                    transaction.Commit();
                    MessageBox.Show("New device added!");
                }
            }
        }

        /// <summary>
        /// Dodawanie do bazy nowego pracownika
        /// </summary>
        public void AddNewEmployee()
        {
            using (var session = NHibernateHelper.OpenSession())
            {
                using (var transaction = session.BeginTransaction())
                {
                    Salon salon = session.QueryOver<Salon>().Where(s => s.Id_Salon == 1).SingleOrDefault();
                    Role role = session.QueryOver<Role>().Where(r => r.Id_Role == 1).SingleOrDefault();
                    Employee employee = new Employee
                    {
                        Name = "Dymitr",
                        Surname = "Dragalow",
                        Login = "bossaking",
                        Passwd = "1234567890",
                        Employee_Role = role,
                        Employee_Salon = salon
                    };

                    session.Save(employee);
                    transaction.Commit();
                    MessageBox.Show("New employee added!");
                }
            }
        }

        /// <summary>
        /// Dodawanie do bazy nowego zlecenia
        /// </summary>
        public void AddNewOrder()
        {
            using (var session = NHibernateHelper.OpenSession())
            {
                using (var transaction = session.BeginTransaction())
                {
                    Client client = session.QueryOver<Client>().Where(c => c.Name == "Mateusz").SingleOrDefault();
                    Device device = session.Get<Device>(1);
                    Employee employee = session.Get<Employee>(1);
                    IList<Problem> problems = session.QueryOver<Problem>().List();

                    Order order = new Order
                    {
                        Client = client,
                        Description = null,
                        Price = 150,
                        Device = device,
                        Employee = employee,
                        Order_Date = DateTime.Now,
                        Reception_Date = null,
                        Order_Status = "W trakcie naprawy",
                        Problems = problems
                    };

                    session.Save(order);
                    transaction.Commit();
                    MessageBox.Show("New order added!");
                }
            }
        }


        #endregion

        #region READ

        /// <summary>
        /// Odczyt wszystkich firm
        /// </summary>
        public void GetAllBrands()
        {
            using (var session = NHibernateHelper.OpenSession())
            {
                using (var transaction = session.BeginTransaction())
                {
                    Brand brand = session.Get<Brand>(1);
                    transaction.Commit();
                }
            }
        }

        /// <summary>
        /// Odzcyt wszystkich klientów
        /// </summary>
        public void GetAllClients()
        {
            using (var session = NHibernateHelper.OpenSession())
            {
                using (var transaction = session.BeginTransaction())
                {
                    IList<Client> clients = session.QueryOver<Client>().List();
                    transaction.Commit();
                }
            }
        }

        /// <summary>
        /// Odczyt wszystkich urządzeń
        /// </summary>
        public void GetAllDivices()
        {
            using (var session = NHibernateHelper.OpenSession())
            {
                using (var transaction = session.BeginTransaction())
                {
                    IList<Device> devices = session.QueryOver<Device>().List();
                    transaction.Commit();
                }
            }
        }

        /// <summary>
        /// Odczyt wszystkich pracowników
        /// </summary>
        public void GetAllEmployees()
        {
            using (var session = NHibernateHelper.OpenSession())
            {
                using (var transaction = session.BeginTransaction())
                {
                    IList<Employee> employees = session.QueryOver<Employee>().List();
                    transaction.Commit();
                }
            }
        }

        /// <summary>
        /// Odczyt wszystkich ról
        /// </summary>
        public void GetAllRoles()
        {
            using (var session = NHibernateHelper.OpenSession())
            {
                using (var transaction = session.BeginTransaction())
                {
                    IList<Role> roles = session.QueryOver<Role>().List();
                    transaction.Commit();
                }
            }
        }

        /// <summary>
        /// Odczyt wszystkich salonów
        /// </summary>
        public void GetAllSalons()
        {
            using (var session = NHibernateHelper.OpenSession())
            {
                using (var transaction = session.BeginTransaction())
                {
                    IList<Salon> salons = session.QueryOver<Salon>().List();
                    transaction.Commit();
                }
            }
        }

        /// <summary>
        /// Odczyt wszystkich typów
        /// </summary>
        public void GetAllTypes()
        {
            using (var session = NHibernateHelper.OpenSession())
            {
                using (var transaction = session.BeginTransaction())
                {
                    IList<Device_Type> types = session.QueryOver<Device_Type>().List();
                    transaction.Commit();
                }
            }
        }

        /// <summary>
        /// Odczyt wszystkich zleceń
        /// </summary>
        public void GetAllOrders()
        {
            using (var session = NHibernateHelper.OpenSession())
            {
                using (var transaction = session.BeginTransaction())
                {
                    IList<Order> orders = session.QueryOver<Order>().List();
                    transaction.Commit();
                }
            }
        }

        /// <summary>
        /// Odczyt wszystkich problemów
        /// </summary>
        public void GetAllProblems()
        {
            using (var session = NHibernateHelper.OpenSession())
            {
                using (var transaction = session.BeginTransaction())
                {
                    IList<Problem> problems = session.QueryOver<Problem>().List();
                    transaction.Commit();
                }
            }
        }

        #endregion

        #region UPDATE

        /// <summary>
        /// Edycja zlecenia
        /// </summary>
        public void SetOrder()
        {
            using (var session = NHibernateHelper.OpenSession())
            {
                using (var transaction = session.BeginTransaction())
                {
                    Order order = session.QueryOver<Order>().Where(o => o.Id_Order == 3).SingleOrDefault();
                    Client client = session.Get<Client>(1);
                    order.Description = "Nowy opis";
                    order.Client = client;
                    session.Update(order);
                    transaction.Commit();
                    MessageBox.Show("Order edited!");
                }
            }
        }

        #endregion


        #region DELETE

        /// <summary>
        /// Usuwanie zlecenia
        /// </summary>
        public void DeleteOrder()
        {
            using (var session = NHibernateHelper.OpenSession())
            {
                using (var transaction = session.BeginTransaction())
                {
                    Order order = session.QueryOver<Order>().Where(o => o.Id_Order == 3).SingleOrDefault();
                    session.Delete(order);
                    transaction.Commit();
                    MessageBox.Show("Order deleted!");
                }
            }
        }

        /// <summary>
        /// Usuwanie problemu
        /// </summary>
        public void DeleteProblem()
        {
            using (var session = NHibernateHelper.OpenSession())
            {
                using (var transaction = session.BeginTransaction())
                {
                    Problem problem = session.Get<Problem>(1);
                    session.Delete(problem);
                    transaction.Commit();
                    MessageBox.Show("Problem deleted!");
                }
            }
        }

        /// <summary>
        /// Usuwanie pracownika
        /// </summary>
        public void DeleteEmployee()
        {
            using (var session = NHibernateHelper.OpenSession())
            {
                using (var transaction = session.BeginTransaction())
                {
                    Employee employee = session.Get<Employee>(2);
                    session.Delete(employee);
                    transaction.Commit();
                    MessageBox.Show("Employee deleted!");
                }
            }
        }

        #endregion

        #endregion


    }
}
