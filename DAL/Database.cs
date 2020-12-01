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

        #region BRANDS TABLE

        public abstract ObservableCollection<Brand> GetBrands();
        public abstract ObservableCollection<Brand> GetBrandsOfType(Device_Type type);
        public abstract bool AddNewBrand(Brand brand);
        public abstract bool UpdateBrand(Brand brand);
        public abstract bool DeleteBrand(Brand brand);

        #endregion

        #region CLIENTS TABLE
        public abstract ObservableCollection<Client> GetAllClients();
        public abstract void AddNewClient(Client client);
        public abstract bool UpdateClient(Client client);
        public abstract bool DeleteClient(int id);
        #endregion

        #region DEVICES TABLE
        public abstract ObservableCollection<Device> GetDevices();
        public abstract ObservableCollection<Device> GetDevicesOfTypeAndBrand(Device_Type type, Brand brand);
        public abstract bool AddNewDevice(Device device);
        public abstract bool UpdateDevice(Device device);
        public abstract bool DeleteDevice(Device device);

        #endregion

        #region DEVICES TYPES TABLE
        public abstract ObservableCollection<Device_Type> GetTypes();
        public abstract bool AddNewType(Device_Type type);
        public abstract bool UpdateType(Device_Type type);
        public abstract bool DeleteType(Device_Type type);
        #endregion

        #region EMPLOYEES TABLE
        public abstract ObservableCollection<Employee> GetEmployees();
        public abstract bool AddNewEmployee(Employee employee);
        public abstract bool UpdateEmployee(Employee employee);
        public abstract bool DeleteEmployee(Employee employee);
        #endregion

        #region ORDERS TABLE
        public abstract ObservableCollection<Order> GetAllOrders();
        public abstract ObservableCollection<Order> GetArchiveOrders();
        public abstract void RestoreOrder(Order order);
        public abstract bool AddNewOrder(Order order);
        public abstract bool UpdateOrder(Order order);
        public abstract void DeleteOrder(int id);
        #endregion

        #region PROBLEMS TABLE
        public abstract ObservableCollection<Problem> GetProblems();
        public abstract bool AddNewProblem(Problem problem);
        public abstract bool UpdateProblem(Problem problem);
        public abstract bool DeleteProblem(Problem problem);
        #endregion

        #region ROLES TABLE
        public abstract ObservableCollection<Role> GetRoles();
        public abstract bool AddNewRole(Role role);
        public abstract bool UpdateRole(Role role);
        public abstract bool DeleteRole(Role role);
        #endregion

        #region SALONS TABLE
        public abstract ObservableCollection<Salon> GetSalons();
        public abstract bool AddNewSalon(Salon salon);
        public abstract bool UpdateSalon(Salon salon);
        public abstract bool DeleteSalon(Salon salon);
        #endregion

        #region STATUSES TABLE
        public abstract ObservableCollection<Status> GetStatuses();
        public abstract bool AddNewStatus(Status status);
        public abstract bool UpdateStatus(Status status);
        public abstract bool DeleteStatus(Status status);
        #endregion


        public abstract bool SingInWithLoginAndPassword(string login, string password);
        

    }
}
