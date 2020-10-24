using FluentNHibernate.Cfg;
using FluentNHibernate.Cfg.Db;
using NHibernate;
using Repair_Service.Controllers;

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
                c => c.FromConnectionStringWithKey("DefaultConnection")).ShowSql())
                    .Mappings(m => m.FluentMappings.AddFromAssemblyOf<MainController>())
                        .BuildSessionFactory();
        }

        public static ISession OpenSession()
        {
            return SessionFactory.OpenSession();
        }

    }
}
