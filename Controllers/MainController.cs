using NHibernate.Cfg;
using NHibernate.Tool.hbm2ddl;
using Repair_Service.Models;
using Repair_Service.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repair_Service.Controllers
{
    public class MainController
    {

        public static void LoadNHibernateCfg()
        {
            Configuration configuration = new Configuration();
            configuration.Configure();
            configuration.AddAssembly(typeof(Client).Assembly);
            new SchemaExport(configuration).Execute(true, true, false);
        }

        public static void AddNewClient()
        {
            ClientRepository clientRepository = new ClientRepository();
            Client client = new Client() { Phone_Number = "+48669706372", Name = "Dymitr", Surname = "Dragalow" };
            clientRepository.Add(client);

        }

    }
}
