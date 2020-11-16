using Repair_Service.DAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repair_Service.Controllers
{
    public class PageController
    {
        protected Database database;

        public PageController()
        {
            database = ProxyDatabase.GetDatabase();
        }
    }
}
