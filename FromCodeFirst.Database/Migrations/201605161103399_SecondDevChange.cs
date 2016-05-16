namespace FromCodeFirst.Database.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class SecondDevChange : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Users", "SecondDevChange", c => c.Int(nullable: false));
        }
        
        public override void Down()
        {
            DropColumn("dbo.Users", "SecondDevChange");
        }
    }
}
