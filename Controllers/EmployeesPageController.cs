using Repair_Service.Models;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repair_Service.Controllers
{
    public class EmployeesPageController : PageController
    {

        public EmployeesPageController() : base() { }

        public async Task<ObservableCollection<Employee>> GetEmployeesAsync()
        {
            ObservableCollection<Employee> employees = new ObservableCollection<Employee>();
            await Task.Run(() => employees = database.GetEmployees());
            return employees;
        }

        public async Task<ObservableCollection<Salon>> GetSalonsAsync()
        {
            ObservableCollection<Salon> salons = new ObservableCollection<Salon>();
            await Task.Run(() => salons = database.GetSalons());
            return salons;
        }

        public async Task<ObservableCollection<Role>> GetRolesAsync()
        {
            ObservableCollection<Role> roles = new ObservableCollection<Role>();
            await Task.Run(() => roles = database.GetRoles());
            return roles;
        }

        public async Task<bool> AddNewEmployeeAsync(Employee employee)
        {
            return await Task.Run(() => database.AddNewEmployee(employee));
        }

        public async Task<bool> UpdateEmployeeAsync(Employee employee)
        {
            return await Task.Run(() => database.UpdateEmployee(employee));
        }

        public async Task<bool> DeleteEmployeeAsync(Employee employee)
        {
            return await Task.Run(() => database.DeleteEmployee(employee));
        }

    }
}
