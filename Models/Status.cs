﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repair_Service.Models
{
    public class Status
    {
        public virtual int Id_Status { get; set; }
        public virtual string Title { get; set; }
        public virtual IList<Order> Orders { get; set; }

    }
}