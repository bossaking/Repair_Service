using FluentNHibernate.Mapping;
using Repair_Service.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repair_Service.HibernateMapping
{
    class ProblemMap : ClassMap<Problem>
    {

        public ProblemMap()
        {
            Id(x => x.Id_Problem).GeneratedBy.Increment();

            Map(x => x.Title);

            HasManyToMany(x => x.Orders).Inverse().Table("orders_problems").ParentKeyColumn("Id_Problem").ChildKeyColumn("Id_Order").LazyLoad();

            Table("problems");
        }

    }
}
