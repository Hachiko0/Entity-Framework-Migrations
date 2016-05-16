namespace FromCodeFirst.Database.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class FirstDevChange3 : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Users", "SecondDevChange3", c => c.Int(nullable: false));
        }
        
        public override void Down()
        {
            DropColumn("dbo.Users", "SecondDevChange3");
        }
    }
}
