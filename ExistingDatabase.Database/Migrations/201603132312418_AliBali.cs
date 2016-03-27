namespace ExistingDatabase.Database.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AliBali : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Categories", "AliBali", c => c.String());
        }
        
        public override void Down()
        {
            DropColumn("dbo.Categories", "AliBali");
        }
    }
}
