namespace Goplecs.GTracker.DAL.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class addedPhotocolumn : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.User", "Photo", c => c.Binary());
        }
        
        public override void Down()
        {
            DropColumn("dbo.User", "Photo");
        }
    }
}
