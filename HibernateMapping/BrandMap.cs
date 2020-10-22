using FluentNHibernate.Mapping;
using Repair_Service.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repair_Service.HibernateMapping
{
    class BrandMap : ClassMap<Brand>
    {
        public BrandMap()
        {
            Id(x => x.Id_Brand).GeneratedBy.Increment();

            Map(x => x.Title);

            HasMany(x => x.Devices);

            Table("brands");
        }
    }
}
