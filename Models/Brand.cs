using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repair_Service.Models
{
    public class Brand
    {
        public virtual int Id_Brand { get; set; }
        public virtual string Title { get; set; }
        public virtual IList<Device> Devices { get; set; }
    }
}
