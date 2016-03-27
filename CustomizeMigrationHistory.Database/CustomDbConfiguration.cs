using System.Data.Entity;
using System.Data.Entity.Migrations.History;
using System.Data.Entity.SqlServer;
using System.Data.Entity.Infrastructure;
using CustomizeMigrationHistory.Database.Migrations;

namespace CustomizeMigrationHistory.Database
{
    public class CustomDbConfiguration : DbConfiguration
    {
        public CustomDbConfiguration()
        {
            this.SetHistoryContext(SqlProviderServices.ProviderInvariantName,
                (connection, defaultSchema) =>
                new MyHistoryContext(connection, defaultSchema));

            //this.SetDefaultConnectionFactory(new SqlConnectionFactory(
            //    "data source=KRASI;initial catalog=MyDbContext;integrated security=True;MultipleActiveResultSets=True;App=EntityFramework"));

            //this.SetDatabaseInitializer(new MigrateDatabaseToLatestVersion<MyDbContext, Configuration>());
            //this.SetDatabaseInitializer(new NullDatabaseInitializer<MyDbContext>());s
        }
    }
}
