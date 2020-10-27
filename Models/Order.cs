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
        public virtual Client Client { get; set; }
        public virtual string Description { get; set; }
        public virtual decimal Price { get; set; }
        public virtual Device Device { get; set; }
        public virtual Employee Employee { get; set; }
        public virtual DateTime Order_Date { get; set; }
        public virtual DateTime? Reception_Date { get; set; }
        public virtual string Order_Status { get; set; }
        public virtual IList<Problem> Problems { get; set; }
    }
}
