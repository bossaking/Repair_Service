using FluentNHibernate.Mapping;
using Repair_Service.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repair_Service.HibernateMapping
{
    class ClientMap : ClassMap<Client>
    {

        public ClientMap()
        {
            Id(x => x.Id_Client).GeneratedBy.Increment();

            Map(x => x.Phone_Number);
            Map(x => x.Name).Nullable();
            Map(x => x.Surname).Nullable();

            HasMany(x => x.Orders).Not.LazyLoad();

            Table("clients");
        }

    }
}
