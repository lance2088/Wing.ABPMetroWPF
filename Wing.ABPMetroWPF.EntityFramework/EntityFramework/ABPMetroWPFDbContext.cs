﻿using System.Data.Entity;
using Abp.EntityFramework;
using Wing.ABPMetroWPF.People;

namespace Wing.ABPMetroWPF.EntityFramework
{
    public class ABPMetroWPFDbContext : AbpDbContext
    {
        public virtual IDbSet<Person> People { get; set; }

        /* NOTE: 
         *   Setting "Default" to base class helps us when working migration commands on Package Manager Console.
         *   But it may cause problems when working Migrate.exe of EF. If you will apply migrations on command line, do not
         *   pass connection string name to base classes. ABP works either way.
         */
        public ABPMetroWPFDbContext()
            : base("Default")
        {

        }

        /* NOTE:
         *   This constructor is used by ABP to pass connection string defined in ABPMetroWPFDataModule.PreInitialize.
         *   Notice that, actually you will not directly create an instance of ABPMetroWPFDbContext since ABP automatically handles it.
         */
        public ABPMetroWPFDbContext(string nameOrConnectionString)
            : base(nameOrConnectionString)
        {

        }
    }
}
