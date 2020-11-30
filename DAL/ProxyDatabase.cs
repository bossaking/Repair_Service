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

        ObservableCollection<Brand> brands;
        ObservableCollection<Client> clients;
        ObservableCollection<Device> devices;
        ObservableCollection<Device_Type> types;
        ObservableCollection<Employee> employees;
        ObservableCollection<Order> orders;
        ObservableCollection<Order> archiveOrders;
        ObservableCollection<Problem> problems;
        ObservableCollection<Role> roles;
        ObservableCollection<Salon> salons;
        ObservableCollection<Status> statuses;

        private static ProxyDatabase instance;

        private ProxyDatabase()
        {
        }

        public static ProxyDatabase GetDatabase()
        {
            if (instance == null) instance = new ProxyDatabase();
            return instance;
        }

        #region BRANDS TABLE

        /// <summary>
        /// Zwraca listę wszystkich firm-producentów urządzeń
        /// </summary>
        /// <returns>Zwraca listę wszystkich firm</returns>
        public override ObservableCollection<Brand> GetBrands()
        {
            if (brands == null)
            {
                brands = database == null ? (database = new MainDatabase()).GetBrands() : database.GetBrands();
            }

            return brands;
        }

        public override ObservableCollection<Brand> GetBrandsOfType(Device_Type type)
        {
            return new ObservableCollection<Brand>(brands.Where(b => b.Devices.FirstOrDefault(d => d.Device_Type.Id_Type == type.Id_Type) != null));
        }

        public override bool AddNewBrand(Brand brand)
        {
            if (BrandExists(brand)) return false;
            App.Current.Dispatcher.Invoke(() => brands.Add(brand));
            return database.AddNewBrand(brand);
        }


        public override bool UpdateBrand(Brand brand)
        {
            if (BrandExists(brand)) return false;

            if (database.UpdateBrand(brand))
            {
                Brand oldBrand = brands.FirstOrDefault(b => b.Id_Brand == brand.Id_Brand);
                App.Current.Dispatcher.Invoke(() => brands[brands.IndexOf(oldBrand)] = brand);
                orders = database.GetAllOrders();
                devices = database.GetDevices();
                return true;
            }
            return false;
        }

        private bool BrandExists(Brand brand)
        {
            return brands.FirstOrDefault(b => b.Title == brand.Title) != null;
        }

        public override bool DeleteBrand(Brand brand)
        {
            if (devices.FirstOrDefault(d => d.Device_Brand.Id_Brand == brand.Id_Brand) != null) return false;


            App.Current.Dispatcher.Invoke(() => brands.Remove(brand));
            return database.DeleteBrand(brand);
        }

        #endregion

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
        public override bool UpdateClient(Client client)
        {
            if (EditClientExists(client)) return false;

            if (database.UpdateClient(client))
            {
                Client oldClient = clients.First(c => c.Id_Client == client.Id_Client);

                App.Current.Dispatcher.Invoke(() =>
                    clients[clients.IndexOf(oldClient)] = client
                );
                orders = database.GetAllOrders();
                return true;
            }
            return false;


        }

        /// <summary>
        /// Pozwala na usunięcie klienta z bazy danych
        /// </summary>
        /// <param name="id">Id klienta</param>
        /// <returns>Zwraca TRUE jeżeli udało się usunąć klienta</returns>
        public override bool DeleteClient(int id)
        {
            if (orders.FirstOrDefault(o => o.Client.Id_Client == id) != null) return false;

            database.DeleteClient(id);
            App.Current.Dispatcher.Invoke(() => clients.Remove(clients.Where(o => o.Id_Client == id).FirstOrDefault()));
            return true;
        }

        /// <summary>
        /// Pozwala sprawdzić czy podany klient już znajduje się w bazie danych
        /// </summary>
        /// <param name="client">Obiekt klasy Client</param>
        /// <returns>Zwraca TRUE jeżeli dany klient już znajduje się w bazie</returns>
        private bool ClientExists(Client client)
        {
            if (clients == null) GetAllClients();
            Client repeatClient = clients.Where(c => c.Name == client.Name && c.Surname == client.Surname && c.Phone_Number == client.Phone_Number &&
                c.Id_Client != client.Id_Client).FirstOrDefault();
            return repeatClient != null;
        }

        private bool EditClientExists(Client client)
        {
            Client repeatClient = clients.Where(c => c.Name == client.Name && c.Surname == client.Surname && c.Phone_Number == c.Phone_Number
                && c.Id_Client != client.Id_Client).FirstOrDefault();
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

        #region DEVICES TABLE

        /// <summary>
        /// Zwraca listę wszystkich urządzeń
        /// </summary>
        /// <returns>Lista wszystkich urządzeń</returns>
        public override ObservableCollection<Device> GetDevices()
        {
            if (devices == null)
            {
                devices = database == null ? (database = new MainDatabase()).GetDevices() : database.GetDevices();
            }

            return devices;
        }

        /// <summary>
        /// Pozwala na dodanie urządzenia do listy oraz do bazy danych
        /// </summary>
        /// <param name="device">Obiekt klasy Device</param>
        /// <returns>Zwraca TRUE jeżeli udało się dodać urządzenie</returns>
        public override bool AddNewDevice(Device device)
        {
            if (DeviceExists(device)) return false;
            App.Current.Dispatcher.Invoke(() => devices.Add(device));
            return database.AddNewDevice(device);
        }


        public override bool UpdateDevice(Device device)
        {
            if (DeviceExists(device)) return false;

            if (database.UpdateDevice(device))
            {
                Device oldDevice = devices.FirstOrDefault(d => d.Id_Device == device.Id_Device);
                App.Current.Dispatcher.Invoke(() => devices[devices.IndexOf(oldDevice)] = device);
                orders = database.GetAllOrders();
                return true;
            }

            return false;
        }

        /// <summary>
        /// Sprawdza czy podane urządzenie akrualnie znajduje się na liście wszystkich urządzeń
        /// </summary>
        /// <param name="device">Obiekt klasy Device</param>
        /// <returns>Zwraca TRUE jeżeli podane urządzenie aktualnie znajduje się na liście wszystkich urządzeń</returns>
        private bool DeviceExists(Device device)
        {
            return devices.FirstOrDefault(d => d.Model_Title.Equals(device.Model_Title) && d.Device_Type.Type_Title.Equals(device.Device_Type.Type_Title)
                && d.Device_Brand.Title.Equals(device.Device_Brand.Title)) != null;
        }

        /// <summary>
        /// Pozwala na usunięcie urządzenia z listy oraz z bazy danych
        /// </summary>
        /// <param name="id">Id urządzenia</param>
        /// <returns>Zwraca TRUE jeżeli udało się usunąć urządzenie</returns>
        public override bool DeleteDevice(Device device)
        {
            if (orders.FirstOrDefault(o => o.Device.Id_Device == device.Id_Device) != null) return false;

            database.DeleteDevice(device);
            App.Current.Dispatcher.Invoke(() => devices.Remove(device));
            return true;
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

        public override bool AddNewType(Device_Type type)
        {
            if (TypeExists(type)) return false;
            App.Current.Dispatcher.Invoke(() => types.Add(type));
            return database.AddNewType(type);
        }


        public override bool UpdateType(Device_Type type)
        {
            if (TypeExists(type)) return false;

            if (database.UpdateType(type))
            {
                Device_Type oldType = types.FirstOrDefault(t => t.Id_Type == type.Id_Type);
                App.Current.Dispatcher.Invoke(() => types[types.IndexOf(oldType)] = type);
                orders = database.GetAllOrders();
                devices = database.GetDevices();

                return true;
            }
            return false;
        }

        private bool TypeExists(Device_Type type)
        {
            return types.FirstOrDefault(t => t.Type_Title.Equals(type.Type_Title)) != null;
        }

        public override bool DeleteType(Device_Type type)
        {
            if (orders.FirstOrDefault(o => o.Device.Device_Type.Id_Type == type.Id_Type) != null) return false;
            database.DeleteType(type);
            App.Current.Dispatcher.Invoke(() => types.Remove(type));
            return true;
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


        public override bool AddNewEmployee(Employee employee)
        {
            App.Current.Dispatcher.Invoke(() => employees.Add(employee));
            return database.AddNewEmployee(employee);
        }


        public override bool UpdateEmployee(Employee employee)
        {
            if (database.UpdateEmployee(employee))
            {
                Employee oldEmployee = employees.FirstOrDefault(e => e.Id_Employee == employee.Id_Employee);
                App.Current.Dispatcher.Invoke(() => employees[employees.IndexOf(oldEmployee)] = employee);
                orders = database.GetAllOrders();
                return true;
            }
            return false;
        }

        public override bool DeleteEmployee(Employee employee)
        {
            if (orders.FirstOrDefault(o => o.Employee.Id_Employee == employee.Id_Employee) != null) return false;
            App.Current.Dispatcher.Invoke(() => employees.Remove(employee));
            return database.DeleteEmployee(employee);
        }
        #endregion

        #region ORDERS TABLE




        /// <summary>
        /// Zwraca listę wszystkich zleceń
        /// </summary>
        /// <returns>Lista wszystkich zleceń</returns>
        public override ObservableCollection<Order> GetAllOrders()
        {
            if (orders == null)
            {
                ObservableCollection<Order> allOrders = database == null ? (database = new MainDatabase()).GetAllOrders() : database.GetAllOrders();
                archiveOrders = new ObservableCollection<Order>();
                orders = new ObservableCollection<Order>();
                foreach(Order order in allOrders)
                {
                    if(order.Status.Title.Equals("Odebrany") || order.Status.Title.Equals("Niezrealizowany"))
                    {
                        App.Current.Dispatcher.Invoke(() =>
                        {
                            archiveOrders.Add(order);
                        });
                    }
                    else
                    {
                        App.Current.Dispatcher.Invoke(() =>
                        {
                            orders.Add(order);
                        });
                    }
                }
            }

            return orders;
        }

        public override ObservableCollection<Order> GetArchiveOrders()
        {
            return archiveOrders;
        }

        public override void RestoreOrder(Order order)
        {
            App.Current.Dispatcher.Invoke(() =>
            {
                archiveOrders.Remove(order);
                order.Status = GetStatus(1);
                orders.Add(order);
            });
        }

        public override bool AddNewOrder(Order order)
        {
            AddNewClient(order.Client);
            order.Client.Id_Client = GetClientId(order.Client);
            order.Status = GetStatus(1);
            if (database.AddNewOrder(order))
            {
                App.Current.Dispatcher.Invoke(() => orders.Add(order));
                return true;
            }
            return false;
        }

        public override bool UpdateOrder(Order order)
        {
            if (database.UpdateOrder(order))
            {
                Order oldOrder = orders.FirstOrDefault(o => o.Id_Order == order.Id_Order);
                App.Current.Dispatcher.Invoke(() => orders[orders.IndexOf(oldOrder)] = order);

                if (order.Status.Title.Equals("Odebrany") || order.Status.Title.Equals("Niezrealizowany"))
                {
                    App.Current.Dispatcher.Invoke(() => { orders.Remove(order); if (archiveOrders == null) archiveOrders = new ObservableCollection<Order>();
                        archiveOrders.Add(order); });
                }

                return true;
            }
            return false;
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

        public override bool AddNewProblem(Problem problem)
        {
            if (ProblemExists(problem)) return false;
            App.Current.Dispatcher.Invoke(() => problems.Add(problem));
            return database.AddNewProblem(problem);
        }

        public override bool UpdateProblem(Problem problem)
        {
            if (ProblemExists(problem)) return false;

            if (database.UpdateProblem(problem))
            {
                Problem oldProblem = problems.FirstOrDefault(p => p.Id_Problem == problem.Id_Problem);
                App.Current.Dispatcher.Invoke(() => problems[problems.IndexOf(oldProblem)] = problem);
                orders = GetAllOrders();
                return true;
            }
            return false;
        }

        private bool ProblemExists(Problem problem)
        {
            return problems.FirstOrDefault(p => p.Title == problem.Title) != null;
        }

        public override bool DeleteProblem(Problem problem)
        {
            if (orders.FirstOrDefault(o => o.Problems.FirstOrDefault(p => p.Id_Problem == problem.Id_Problem) != null) != null) return false;
            App.Current.Dispatcher.Invoke(() => problems.Remove(problem));
            return database.DeleteProblem(problem);
        }

        #endregion

        #region ROLES TABLE

        public override ObservableCollection<Role> GetRoles()
        {
            if (roles == null)
            {
                roles = database == null ? (database = new MainDatabase()).GetRoles() : database.GetRoles();
            }

            return roles;
        }

        public override bool AddNewRole(Role role)
        {
            if (RoleExists(role)) return false;
            App.Current.Dispatcher.Invoke(() => roles.Add(role));
            return database.AddNewRole(role);
        }


        public override bool UpdateRole(Role role)
        {
            if (RoleExists(role)) return false;

            if (database.UpdateRole(role))
            {
                Role oldRole = roles.FirstOrDefault(r => r.Id_Role == role.Id_Role);
                App.Current.Dispatcher.Invoke(() => roles[roles.IndexOf(oldRole)] = role);
                employees = database.GetEmployees();
                return true;
            }
            return false;
        }

        private bool RoleExists(Role role)
        {
            return roles.FirstOrDefault(r => r.Title == role.Title) != null;
        }

        public override bool DeleteRole(Role role)
        {
            if (employees.FirstOrDefault(e => e.Employee_Role.Id_Role == role.Id_Role) != null) return false;
            App.Current.Dispatcher.Invoke(() => roles.Remove(role));
            return database.DeleteRole(role);
        }

        #endregion

        #region SALONS TABLE

        public override ObservableCollection<Salon> GetSalons()
        {
            if (salons == null)
            {
                salons = database == null ? (database = new MainDatabase()).GetSalons() : database.GetSalons();
            }
            return salons;
        }

        public override bool AddNewSalon(Salon salon)
        {
            if (SalonExists(salon)) return false;
            App.Current.Dispatcher.Invoke(() => salons.Add(salon));
            return database.AddNewSalon(salon);
        }


        public override bool UpdateSalon(Salon salon)
        {
            if (SalonExists(salon)) return false;

            if (database.UpdateSalon(salon))
            {
                Salon oldSalon = salons.FirstOrDefault(s => s.Id_Salon == salon.Id_Salon);
                App.Current.Dispatcher.Invoke(() => salons[salons.IndexOf(oldSalon)] = salon);
                employees = database.GetEmployees();
                return true;
            }
            return false;
        }

        private bool SalonExists(Salon salon)
        {
            return salons.FirstOrDefault(s => s.Title == salon.Title && s.Location == s.Location) != null;
        }

        public override bool DeleteSalon(Salon salon)
        {
            if (employees.FirstOrDefault(e => e.Employee_Salon.Id_Salon == salon.Id_Salon) != null) return false;
            App.Current.Dispatcher.Invoke(() => salons.Remove(salon));
            return database.DeleteSalon(salon);
        }

        #endregion

        #region STATUSES TABLE

        public override ObservableCollection<Status> GetStatuses()
        {
            if (statuses == null)
            {
                statuses = database == null ? (database = new MainDatabase()).GetStatuses() : database.GetStatuses();
            }

            return statuses;
        }

        public override bool AddNewStatus(Status status)
        {
            if (StatusExists(status)) return false;

            if (database.AddNewStatus(status))
            {
                App.Current.Dispatcher.Invoke(() => statuses.Add(status));
                return true;
            }
            return false;
        }


        public override bool UpdateStatus(Status status)
        {
            if (StatusExists(status)) return false;

            if (database.UpdateStatus(status))
            {
                Status oldStatus = statuses.FirstOrDefault(s => s.Id_Status == status.Id_Status);
                App.Current.Dispatcher.Invoke(() => statuses[statuses.IndexOf(oldStatus)] = status);
                orders = database.GetAllOrders();
                return true;
            }
            return false;
        }

        private bool StatusExists(Status status)
        {
            return statuses.FirstOrDefault(s => s.Title == status.Title) != null;
        }

        public override bool DeleteStatus(Status status)
        {
            if (orders.FirstOrDefault(o => o.Status.Id_Status == status.Id_Status) != null) return false;
            if (database.DeleteStatus(status))
            {
                App.Current.Dispatcher.Invoke(() => statuses.Remove(status));
                return true;
            }
            return false;
        }

        private Status GetStatus(int id)
        {
            return statuses.FirstOrDefault(s => s.Id_Status == id);
        }

        #endregion



        private void GetAllData()
        {
            GetDatabase();
            GetBrands();
            GetAllClients();
            GetDevices();
            GetTypes();
            GetEmployees();
            GetAllOrders();
            GetProblems();
            GetRoles();
            GetSalons();
            GetStatuses();
        }






        public override bool SingInWithLoginAndPassword(string login, string password)
        {
            if (database == null) database = new MainDatabase();
            if (database.SingInWithLoginAndPassword(login, password))
            {
                GetAllData();
                return true;
            }
            return false;
        }



    }
}
