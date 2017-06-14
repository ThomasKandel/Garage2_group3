namespace Garage2.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class addedvalidationstovehicleclass : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.Vehicles", "RegNum", c => c.String(nullable: false));
        }
        
        public override void Down()
        {
            AlterColumn("dbo.Vehicles", "RegNum", c => c.String());
        }
    }
}
