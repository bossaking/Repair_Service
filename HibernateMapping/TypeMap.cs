using FluentNHibernate.Mapping;
using Repair_Service.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repair_Service.HibernateMapping
{
    class TypeMap : ClassMap<Device_Type>
    {

        public TypeMap()
        {
            Id(x => x.Id_Type).GeneratedBy.Increment();

            Map(x => x.Type_Title);

            HasMany(x => x.Devices).Not.LazyLoad();

            Table("types");
        }

    }
}
