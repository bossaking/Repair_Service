using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repair_Service.Models
{
    public class Device_Type
    {
        

        public virtual int Id_Type { get; set; }
        public virtual string Type_Title { get; set; }
        public virtual IList<Device> Devices { get; set; }

    }
}
