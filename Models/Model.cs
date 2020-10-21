using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repair_Service.Models
{
    public class Model
    {
        public virtual int Id_Model { get; set; }
        public virtual string Title { get; set; }
        public virtual int Id_Brand { get; set; }
    }
}
