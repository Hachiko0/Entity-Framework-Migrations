namespace ExistingDatabase.Database.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddAge : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Categories", "Age", c => c.Int(nullable: false));
        }
        
        public override void Down()
        {
            DropColumn("dbo.Categories", "Age");
        }
    }
}
