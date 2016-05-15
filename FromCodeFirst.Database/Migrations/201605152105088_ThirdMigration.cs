namespace FromCodeFirst.Database.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class ThirdMigration : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Users", "RandomProperty3", c => c.String());
            AddColumn("dbo.Users", "RandomProperty4", c => c.String());
        }
        
        public override void Down()
        {
            DropColumn("dbo.Users", "RandomProperty4");
            DropColumn("dbo.Users", "RandomProperty3");
        }
    }
}
