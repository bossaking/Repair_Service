﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repair_Service.Models
{
    public class Problem
    {
        public virtual int Id_Problem { get; set; }
        public virtual string Title { get; set; }
    }
}