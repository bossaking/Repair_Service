using FluentNHibernate.Mapping;
using Repair_Service.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repair_Service.HibernateMapping
{
    class RoleMap : ClassMap<Role>
    {

        public RoleMap()
        {
            Id(x => x.Id_Role).GeneratedBy.Increment();

            Map(x => x.Title);

            HasMany(x => x.Employees).Not.LazyLoad();

            Table("roles");
        }

    }
}
