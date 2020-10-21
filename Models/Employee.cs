using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repair_Service.Models
{
    public class Employee
    {
        public virtual int Id_Employee { get; set; }
        public virtual string Name { get; set; }
        public virtual string Surname { get; set; }
        public virtual int Id_Salon { get; set; }
        public virtual int Id_Role { get; set; }
        public virtual string Login { get; set; }
        public virtual string Passwd { get; set; }

    }
}
