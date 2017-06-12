namespace Garage2.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class NullableCheckOutTime : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.Vehicles", "CheckOutTime", c => c.DateTime());
        }
        
        public override void Down()
        {
            AlterColumn("dbo.Vehicles", "CheckOutTime", c => c.DateTime(nullable: false));
        }
    }
}
