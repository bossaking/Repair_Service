using FluentNHibernate.Mapping;
using Repair_Service.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repair_Service.HibernateMapping
{
    class DeviceMap : ClassMap<Device>
    {

        public DeviceMap()
        {
            Id(x => x.Id_Device).GeneratedBy.Increment();

            Map(x => x.Model_Title);

            References(x => x.Device_Type).Column("Id_Type").Not.LazyLoad();
            References(x => x.Device_Brand).Column("Id_Brand").Not.LazyLoad();

            HasMany(x => x.Orders).Not.LazyLoad().Not.LazyLoad();

            Table("devices");
        }

    }
}
