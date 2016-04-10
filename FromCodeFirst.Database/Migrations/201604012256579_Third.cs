namespace FromCodeFirst.Database.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Third : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Users", "RandomProperty3", c => c.String());
        }
        
        public override void Down()
        {
            DropColumn("dbo.Users", "RandomProperty3");
        }
    }
}
