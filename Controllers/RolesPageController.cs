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
    public class RolesPageController : PageController
    {

        public RolesPageController() : base() { }

        public async Task<ObservableCollection<Role>> GetRolesAsync()
        {
            ObservableCollection<Role> roles = new ObservableCollection<Role>();
            await Task.Run(() => roles = database.GetRoles());
            return roles;
        }

        public async Task<bool> AddNewRoleAsync(Role role)
        {
            return await Task.Run(() => database.AddNewRole(role));
        }

        public async Task<bool> UpdateRoleAsync(Role role)
        {
            return await Task.Run(() => database.UpdateRole(role));
        }

        public async Task<bool> DeleteRoleAsync(Role role)
        {
            return await Task.Run(() => database.DeleteRole(role));
        }

        public async Task<bool> RefreshRoles()
        {
            return await Task.Run(() => (database as ProxyDatabase).RefreshRoles());
        }
    }
}
