using System;

namespace Repair_Service.Models
{
    public class Client
    {
        public virtual int Id_Client { get; set; }
        public virtual string Phone_Number { get; set; }
        public virtual string Name { get; set; }
        public virtual string Surname { get; set; }
    }
}
