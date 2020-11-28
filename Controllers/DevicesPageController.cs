using Repair_Service.Models;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repair_Service.Controllers
{
    public class DevicesPageController : PageController
    {

        public DevicesPageController() : base()
        {

        }

        public async Task<bool> AddNewDevice(Device device)
        {
            return await Task.Run(() => database.AddNewDevice(device));
        }

        public async Task<ObservableCollection<Device>> GetDevicesAsync()
        {
            ObservableCollection<Device> devices = new ObservableCollection<Device>();

            await Task.Run(() => devices = database.GetDevices());
            return devices;
        }

        public async Task<ObservableCollection<Device_Type>> GetTypesAsync()
        {
            ObservableCollection<Device_Type> device_Types = new ObservableCollection<Device_Type>();
            await Task.Run(() => device_Types = database.GetTypes());
            return device_Types;
        }

        public async Task<ObservableCollection<Brand>> GetBrandsAsync()
        {
            ObservableCollection<Brand> brands = new ObservableCollection<Brand>();
            await Task.Run(() => brands = database.GetBrands());
            return brands;
        }

        public async Task<bool> UpdateDeviceAsync(Device device)
        {
            return await Task.Run(() => database.UpdateDevice(device));
        }

        public async Task<bool> DeleteDeviceAsync(Device device)
        {
            return await Task.Run(() => database.DeleteDevice(device));
        }

    }
}
