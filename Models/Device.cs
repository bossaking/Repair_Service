using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repair_Service.Models
{
    public class Device
    {
        public virtual int Id_Device { get; set; }
        public virtual string Model_Title { get; set; }
        public virtual Device_Type Device_Type { get; set; }
        public virtual Brand Device_Brand { get; set; }
        public virtual IList<Order> Orders { get; set; }
    }
}
