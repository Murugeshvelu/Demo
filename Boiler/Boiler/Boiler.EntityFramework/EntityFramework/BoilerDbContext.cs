using System.Data.Common;
using Abp.Zero.EntityFramework;
using Boiler.Authorization.Roles;
using Boiler.MultiTenancy;
using Boiler.Users;

namespace Boiler.EntityFramework
{
    public class BoilerDbContext : AbpZeroDbContext<Tenant, Role, User>
    {
        //TODO: Define an IDbSet for your Entities...

        /* NOTE: 
         *   Setting "Default" to base class helps us when working migration commands on Package Manager Console.
         *   But it may cause problems when working Migrate.exe of EF. If you will apply migrations on command line, do not
         *   pass connection string name to base classes. ABP works either way.
         */
        public BoilerDbContext()
            : base("Boiler")
        {

        }

        /* NOTE:
         *   This constructor is used by ABP to pass connection string defined in BoilerDataModule.PreInitialize.
         *   Notice that, actually you will not directly create an instance of BoilerDbContext since ABP automatically handles it.
         */
        public BoilerDbContext(string nameOrConnectionString)
            : base(nameOrConnectionString)
        {

        }

        //This constructor is used in tests
        public BoilerDbContext(DbConnection connection)
            : base(connection, true)
        {

        }
    }
}
