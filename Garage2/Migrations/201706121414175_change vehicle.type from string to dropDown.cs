namespace Garage2.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class changevehicletypefromstringtodropDown : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.Vehicles", "Type", c => c.Int(nullable: false));
        }
        
        public override void Down()
        {
            AlterColumn("dbo.Vehicles", "Type", c => c.String());
        }
    }
}
