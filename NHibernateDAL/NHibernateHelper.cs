/*
 * Date: 19/2/2013
 * Author: Andrew Chang
 * Project: Photography
 * File: NHibernateHlper.cs
 * Description:
 * Helper methods for 
 * - creating Sessions to the database
 * - loading the Nhibernate config file / 
 */

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using NHibernate;
using NHibernate.Cfg;
using Photography.NHibernateDAL.Domain;
using NHibernate.Tool.hbm2ddl;

namespace Photography.NHibernateDAL
{
    // Open connection to database

    public class NHibernateHelper
    {
        private static ISessionFactory _sessionFactory;

        private static ISessionFactory SessionFactory
        {
            get
            {
                if (_sessionFactory == null)
                {
                    var configuration = new Configuration();
                    configuration.Configure();
                    configuration.AddAssembly(typeof(Album).Assembly);
                    _sessionFactory = configuration.BuildSessionFactory();
                }
                return _sessionFactory;
            }
        }

        public static ISession OpenSession()
        {
            return SessionFactory.OpenSession();
        }

        // Load NHibernate configration file - default is hibernate.cfg.xml and configure itself
        // Load assembly that contains mapping information.
        // Generate the schema in the database (default) or update the existing schema
        public static void LoadNHiberateConfig(string schemaType)
        {
            var cfg = new Configuration();
            cfg.Configure();
            cfg.AddAssembly(typeof(Album).Assembly);

            switch (schemaType)
            {
                case "update":
                    new SchemaUpdate(cfg).Execute(true, false);
                    break;
                default:
                    new SchemaExport(cfg).Execute(true, true, false);
                    break;
            }
        }
    }
}
