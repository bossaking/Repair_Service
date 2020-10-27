using FluentNHibernate.Mapping;
using Repair_Service.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repair_Service.HibernateMapping
{
    class SalonMap : ClassMap<Salon>
    {

        public SalonMap()
        {
            Id(x => x.Id_Salon).GeneratedBy.Increment();

            Map(x => x.Title);
            Map(x => x.Location);

            HasMany(x => x.Employees);

            Table("salons");
        }

    }
}
