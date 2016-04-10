namespace FromCodeFirst.Database.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Second : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Users", "RandomProperty2", c => c.String());
        }
        
        public override void Down()
        {
            DropColumn("dbo.Users", "RandomProperty2");
        }
    }
}
