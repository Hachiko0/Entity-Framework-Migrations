namespace FromCodeFirst.Database.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class ForthMigration : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Users", "RandomProperty5", c => c.String());
            AddColumn("dbo.Users", "RandomProperty6", c => c.String());
        }
        
        public override void Down()
        {
            DropColumn("dbo.Users", "RandomProperty6");
            DropColumn("dbo.Users", "RandomProperty5");
        }
    }
}
