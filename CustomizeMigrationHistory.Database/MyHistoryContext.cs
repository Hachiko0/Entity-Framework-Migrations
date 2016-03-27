using System.Data.Common;
using System.Data.Entity;
using System.Data.Entity.Migrations.History;

namespace CustomizeMigrationHistory.Database
{
    public class MyHistoryContext : HistoryContext
    {
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
}
