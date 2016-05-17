using System.Data.Common;
using System.Data.Entity;
using System.Data.Entity.Migrations.History;

namespace CustomizeMigrationHistory.Database
{
    /// <summary>
    /// Migrations history table is supposed to be used solely by Code First Migrations and changing it manually can break migrations. 
    /// However sometimes the default configuration is not suitable and the table needs to be customized, for instance:
    /// *You need to change names and/or facets of the columns to enable a 3rd party Migrations provider
    /// *You want to change the name of the table
    /// *You need to use a non-default schema for the __MigrationHistory table
    /// *You need to store additional data for a given version of the context and therefore you need to add an additional column to the table
    /// </summary>
    public class MyHistoryContext : HistoryContext
    {
        public new DbSet<MyHistoryRow> History { get; set; }

        public MyHistoryContext(DbConnection dbConnection, string defaultSchema)
            : base(dbConnection, defaultSchema)
        {
        }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            //configure the migrations history table in the default way
            base.OnModelCreating(modelBuilder);

            //rename __MigrationHistory to MigrationHistory and change schema from dbo to admin
            modelBuilder
                .Entity<HistoryRow>()
                .ToTable(tableName: "MigrationHistory", schemaName: "admin");

            //rename MigrationId to Migration_ID
            modelBuilder
                .Entity<HistoryRow>()
                .Property(p => p.MigrationId)
                .HasColumnName("Migration_ID");
        }
    }

    public class MyHistoryRow: HistoryRow
    {
        public string ReleaseVersion { get; set; }
    }
}
