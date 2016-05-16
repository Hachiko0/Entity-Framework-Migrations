namespace FromCodeFirst.Database.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class SecondDevChange1 : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Users", "SecondDevChange1", c => c.Int(nullable: false));
        }
        
        public override void Down()
        {
            DropColumn("dbo.Users", "SecondDevChange1");
        }
    }
}
