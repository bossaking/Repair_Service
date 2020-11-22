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
    public class ClientsPageController : PageController
    {

        public ClientsPageController() : base() { }
        

        public async Task<ObservableCollection<Client>> GetClientsAsync()
        {
            ObservableCollection<Client> clients = new ObservableCollection<Client>();

            await Task.Run(() => clients = database.GetAllClients());

            return clients;
        }

        public async Task<bool> DeleteClient(int id)
        {
            return await Task.Run(() => 
                database.DeleteClient(id)
            );
        }

    }
}
