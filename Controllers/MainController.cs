using NHibernate.Cfg;
using NHibernate.Tool.hbm2ddl;
using Renci.SshNet.Messages;
using Repair_Service.Models;
using Repair_Service.NHibernate;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace Repair_Service.Controllers
{
    public class MainController
    {

        //public static void LoadNHibernateCfg()
        //{
        //    Configuration configuration = new Configuration();
        //    configuration.Configure();
        //    configuration.AddAssembly(typeof(Client).Assembly);
        //    new SchemaExport(configuration).Execute(true, true, false);
        //}

        #region CRUD's

        #region CREATE

        /// <summary>
        /// Dodawanie do bazy nowego klienta
        /// </summary>
        public static void AddNewClient()
        {
            using (var session = NHibernateHelper.OpenSession())
            {
                using (var transaction = session.BeginTransaction())
                {
                    Client client = new Client { Name = "Dymitr", Surname = "Dragalow", Phone_Number = "+48669706372" };
                    session.Save(client);
                    transaction.Commit();
                    MessageBox.Show("New client added");
                }
            }
        }

        /// <summary>
        /// Dodawanie do bazy nowej firmy producenta
        /// </summary>
        public static void AddNewBrand()
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
        public static void AddNewType()
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
        public static void AddNewProblem()
        {
            using(var session = NHibernateHelper.OpenSession())
            {
                using(var transaction = session.BeginTransaction())
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
        public static void AddNewRole()
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
        public static void AddNewSalon()
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
        public static void AddNewDevice()
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
        public static void AddNewEmployee()
        {
            using (var session = NHibernateHelper.OpenSession())
            {
                using (var transaction = session.BeginTransaction())
                {
                    Salon salon = session.QueryOver<Salon>().Where(s => s.Id_Salon == 1).SingleOrDefault();
                    Role role = session.QueryOver<Role>().Where(r => r.Id_Role == 1).SingleOrDefault();
                    Employee employee = new Employee { Name = "Dymitr", Surname = "Dragalow", Login = "bossaking", Passwd = "1234567890", Employee_Role = role, 
                        Employee_Salon = salon };

                    session.Save(employee);
                    transaction.Commit();
                    MessageBox.Show("New employee added!");
                }
            }
        }

        /// <summary>
        /// Dodawanie do bazy nowego zlecenia
        /// </summary>
        public static void AddNewOrder()
        {
            using (var session = NHibernateHelper.OpenSession())
            {
                using (var transaction = session.BeginTransaction())
                {
                    Client client = session.QueryOver<Client>().Where(c => c.Id_Client == 1).SingleOrDefault();
                    Device device = session.QueryOver<Device>().Where(d => d.Id_Device == 1).SingleOrDefault();
                    Employee employee = session.QueryOver<Employee>().Where(e => e.Id_Employee == 1).SingleOrDefault();
                    Problem problem = session.Get<Problem>(1);
                    Order order = new Order
                    {
                        Client = client,
                        Description = "Spadł",
                        Price = 130,
                        Device = device,
                        Employee = employee,
                        Order_Date = DateTime.Now,
                        Reception_Date = null,
                        Order_Status = "W trakcie naprawy",
                        Problems = new List<Problem>() { problem }
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
        /// Odczyt wszystkich zleceń
        /// </summary>
        public static void GetAllOrders()
        {
            using (var session = NHibernateHelper.OpenSession())
            {
                using (var transaction = session.BeginTransaction())
                {
                    Order order = session.QueryOver<Order>().Where(o => o.Id_Order == 1).SingleOrDefault();
                    transaction.Commit();
                }
            }
        }

        #endregion

        #region UPDATE

        /// <summary>
        /// Edycja zlecenia
        /// </summary>
        public static void SetOrder()
        {
            using (var session = NHibernateHelper.OpenSession())
            {
                using (var transaction = session.BeginTransaction())
                {
                    Order order = session.QueryOver<Order>().Where(o => o.Id_Order == 1).SingleOrDefault();
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
        public static void DeleteOrder()
        {
            using (var session = NHibernateHelper.OpenSession())
            {
                using (var transaction = session.BeginTransaction())
                {
                    Order order = session.QueryOver<Order>().Where(o => o.Id_Order == 1).SingleOrDefault();
                    session.Delete(order);
                    transaction.Commit();
                    MessageBox.Show("Order deleted!");
                }
            }
        }

        /// <summary>
        /// Usuwanie problemu
        /// </summary>
        public static void DeleteProblem()
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
        public static void DeleteEmployee()
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
