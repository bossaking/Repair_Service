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
        public virtual string Title { get; set; }
        public virtual int Id_Type { get; set; }
        public virtual int  Id_Model { get; set; }
    }
}
