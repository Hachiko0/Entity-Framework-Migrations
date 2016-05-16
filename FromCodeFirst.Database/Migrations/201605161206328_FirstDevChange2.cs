namespace FromCodeFirst.Database.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class FirstDevChange2 : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Users", "FirstDevChange2", c => c.Int(nullable: false));
        }
        
        public override void Down()
        {
            DropColumn("dbo.Users", "FirstDevChange2");
        }
    }
}
