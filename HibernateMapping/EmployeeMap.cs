using FluentNHibernate.Mapping;
using Repair_Service.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repair_Service.HibernateMapping
{
    class EmployeeMap : ClassMap<Employee>
    {

        public EmployeeMap()
        {
            Id(x => x.Id_Employee).GeneratedBy.Increment();

            Map(x => x.Name);
            Map(x => x.Surname);
            Map(x => x.Login);
            Map(x => x.Passwd);

            References(x => x.Employee_Salon).Column("Id_Salon");
            References(x => x.Employee_Role).Column("Id_Role");

            HasMany(x => x.Orders);

            Table("employees");
        }

    }
}
