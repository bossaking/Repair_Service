using FluentNHibernate.Mapping;
using Repair_Service.Models;

namespace Repair_Service.HibernateMapping
{
    class BrandMap : ClassMap<Brand>
    {
        public BrandMap()
        {
            Id(x => x.Id_Brand).GeneratedBy.Increment();

            Map(x => x.Title);

            HasMany(x => x.Devices).Not.LazyLoad();

            Table("brands");
        }
    }
}
