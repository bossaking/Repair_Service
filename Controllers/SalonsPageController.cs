using Repair_Service.Models;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repair_Service.Controllers
{
    public class SalonsPageController : PageController
    {

        public SalonsPageController() : base() { }

        public async Task<ObservableCollection<Salon>> GetSalonsAsync()
        {
            ObservableCollection<Salon> salons = new ObservableCollection<Salon>();
            await Task.Run(() => salons = database.GetSalons());
            return salons;
        }

        public async Task<bool> AddNewSalonAsync(Salon salon)
        {
            return await Task.Run(() => database.AddNewSalon(salon));
        }

        public async Task<bool> UpdateSalonAsync(Salon salon)
        {
            return await Task.Run(() => database.UpdateSalon(salon));
        }

        public async Task<bool> DeleteSalonAsync(Salon salon)
        {
            return await Task.Run(() => database.DeleteSalon(salon));
        }

    }
}
