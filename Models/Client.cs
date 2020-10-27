using System;
using System.Collections;
using System.Collections.Generic;

namespace Repair_Service.Models
{
    public class Client
    {
        public virtual int Id_Client { get; set; }
        public virtual string Phone_Number { get; set; }
        public virtual string Name { get; set; }
        public virtual string Surname { get; set; }
        public virtual IList<Order> Orders { get; set; }
    }
}
