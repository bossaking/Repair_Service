using Repair_Service.Models;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repair_Service.Controllers
{
    public class TypesPageController : PageController
    {
        public TypesPageController() : base() { }

        public async Task<ObservableCollection<Device_Type>> GetTypesAsync()
        {
            ObservableCollection<Device_Type> types = new ObservableCollection<Device_Type>();
            await Task.Run(() => types = database.GetTypes());
            return types;
        }

        public async Task<bool> AddNewTypeAsync(Device_Type type)
        {
            return await Task.Run(() => database.AddNewType(type));
        }

        public async Task<bool> UpdateTypeAsync(Device_Type type)
        {
            return await Task.Run(() => database.UpdateType(type));
        }

        public async Task<bool> DeleteTypeAsync(Device_Type type)
        {
            return await Task.Run(() => database.DeleteType(type));
        }
    }
}
