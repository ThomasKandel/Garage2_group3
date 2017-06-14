namespace Garage2.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class addedmoreDataAnnotationValidatorAttributestovehicleclass : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.Vehicles", "Color", c => c.String(nullable: false, maxLength: 30));
            AlterColumn("dbo.Vehicles", "Brand", c => c.String(nullable: false, maxLength: 30));
            AlterColumn("dbo.Vehicles", "Model", c => c.String(nullable: false, maxLength: 30));
        }
        
        public override void Down()
        {
            AlterColumn("dbo.Vehicles", "Model", c => c.String());
            AlterColumn("dbo.Vehicles", "Brand", c => c.String());
            AlterColumn("dbo.Vehicles", "Color", c => c.String());
        }
    }
}
