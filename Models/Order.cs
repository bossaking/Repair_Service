using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repair_Service.Models
{
    public class Order
    {
        public virtual int Id_Order { get; set; }
        public virtual int Id_Client { get; set; }
        public virtual string Description { get; set; }
        public virtual decimal Price { get; set; }
        public virtual int Id_Device { get; set; }
        public virtual int Id_Employee { get; set; }
        public virtual DateTime Order_Date { get; set; }
        public virtual DateTime Reception_Date { get; set; }
        public virtual string Order_Status { get; set; }
    }
}
