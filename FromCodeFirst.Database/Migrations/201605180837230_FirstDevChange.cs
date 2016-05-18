namespace FromCodeFirst.Database.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class FirstDevChange : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Users", "FirstDevChange", c => c.Int(nullable: false));
        }
        
        public override void Down()
        {
            DropColumn("dbo.Users", "FirstDevChange");
        }
    }
}
