using System;
using System.Reflection;
using NHibernate;
using FluentNHibernate.Cfg.Db;
using FluentNHibernate.Cfg;
using NHibernate.Tool.hbm2ddl;

namespace MyProjectNHibernate2
{
    public class FluentySessionFactory
    {
        private static string ConnectionString = "Server=dartagserver.database.windows.net;Database=DbDartagnan;User Id=dartagnan;Password=Junior301261#;";
        public static ISession session;
        public ITransaction transaction;
        public static ISessionFactory sessionFactory;

        public FluentySessionFactory(){

            sessionFactory = CriarSessionFactory();
            session = sessionFactory.OpenSession();
            transaction = session.BeginTransaction();
        }
        public static ISessionFactory CriarSessionFactory()
        {
            if (session != null)
                return sessionFactory;

            
            IPersistenceConfigurer configDb = SQLAnywhereConfiguration.SQLAnywhere10.ConnectionString(ConnectionString);
            
            var configMap = Fluently.Configure().Database(configDb).Mappings(c => c.FluentMappings.AddFromAssemblyOf<Mapping.TaskMap>());
            session = configMap.BuildSessionFactory();
            
            return sessionFactory;
        }
        public static ISession AbrirSession()
        {
            return CriarSession().OpenSession();
        }

public static ISessionFactory CriarSessionFactory2()
        {
            if (session != null)
                return sessionFactory;

            
            IPersistenceConfigurer configDb = SQLAnywhereConfiguration.SQLAnywhere10.ConnectionString(ConnectionString);
            
            var configMap = Fluently.Configure().Database(configDb).Mappings(c => c.FluentMappings.AddFromAssemblyOf<Mapping.TaskMap>());
            session = configMap.BuildSessionFactory().OpenSession();
            
            return sessionFactory;
        }

    }
}