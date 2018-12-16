using DataMacher.apb.Data;
using DataMacher.apb.Maps;
using FluentNHibernate.Cfg;
using FluentNHibernate.Cfg.Db;
using NHibernate;
using NHibernate.Cfg;
using NHibernate.Tool.hbm2ddl;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataMacher.apb.Utils
{
    public class NHibernateHelper
    {
        public static ISession OpenSession()
        {
            ISessionFactory sessionFactory = Fluently
                .Configure()
                .Database(MsSqlConfiguration.MsSql2005
                .ConnectionString(c => c.Is("Server=localhost;Database=test;User ID=root;Password=test;"))
                .Provider("NHibernate.Connection.DriverConnectionProvider")
                .Driver("NHibernate.Driver.MySqlDataDriver")
                .Dialect("NHibernate.Dialect.MySQL5Dialect")
                .ShowSql())


                .Mappings(m => m.FluentMappings.AddFromAssemblyOf<InstantaMap>())
                .Mappings(m => m.FluentMappings.AddFromAssemblyOf<StareMap>())
                .Mappings(m => m.FluentMappings.AddFromAssemblyOf<ActMap>())
                .Mappings(m => m.FluentMappings.AddFromAssemblyOf<SituatieMap>())


                .BuildSessionFactory();
            return sessionFactory.OpenSession();
        }
    }
}
