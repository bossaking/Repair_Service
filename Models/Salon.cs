using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repair_Service.Models
{
    public class Salon
    {
        public virtual int Id_Salon { get; set; }
        public virtual string Title { get; set; }
        public virtual string Location { get; set; }
    }
}
