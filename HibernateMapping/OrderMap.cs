using FluentNHibernate.Mapping;
using NHibernate.Proxy;
using Repair_Service.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repair_Service.HibernateMapping
{
    class OrderMap : ClassMap<Order>
    {

        public OrderMap()
        {
            Id(x => x.Id_Order).GeneratedBy.Increment();

            Map(x => x.Description);
            Map(x => x.Price);
            Map(x => x.Order_Date);
            Map(x => x.Reception_Date).Nullable();
            Map(x => x.Order_Status);

            References(x => x.Client).Column("Id_Client").Not.LazyLoad();
            References(x => x.Device).Column("Id_Device").Not.LazyLoad();
            References(x => x.Employee).Column("Id_Employee").Not.LazyLoad();

            HasManyToMany(x => x.Problems).Table("orders_problems").ParentKeyColumn("Id_Order").ChildKeyColumn("Id_Problem").LazyLoad();

            Table("orders");
        }

    }
}
