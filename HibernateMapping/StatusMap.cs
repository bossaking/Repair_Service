using FluentNHibernate.Mapping;
using Repair_Service.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repair_Service.HibernateMapping
{
    class StatusMap : ClassMap<Status>
    {
        public StatusMap()
        {
            Id(x => x.Id_Status).GeneratedBy.Increment();

            Map(x => x.Title);

            HasMany(x => x.Orders).Not.LazyLoad();

            Table("statuses");
        }
    }
}
