using FluentNHibernate.Cfg;
using FluentNHibernate.Cfg.Db;
using NHibernate;
using NHibernate.Caches.SysCache;
using NHibernate.Connection;
using NHibernate.Driver;
using Repair_Service.Controllers;
using Repair_Service.DAL;

namespace Repair_Service.NHibernate
{
    public class NHibernateHelper
    {

        private static ISessionFactory _sessionFactory;

        private static ISessionFactory SessionFactory
        {
            get
            {
                if (_sessionFactory == null)
                {
                    InitializeSessionFactory();
                }
                return _sessionFactory;
            }
        }

        private static void InitializeSessionFactory()
        {
            _sessionFactory = Fluently.Configure().Database(MySQLConfiguration.Standard.ConnectionString(
                c => c.FromConnectionStringWithKey("DefaultConnection")).ShowSql()).Cache(c => c.ProviderClass<SysCacheProvider>().UseQueryCache())
                    .Mappings(m => m.FluentMappings.AddFromAssemblyOf<Database>())
                    
                       
                        .BuildSessionFactory();
            _sessionFactory.Statistics.IsStatisticsEnabled = true;
        }

        public static ISession OpenSession()
        {
            return SessionFactory.OpenSession();
        }

    }
}
