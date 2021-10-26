namespace EFTest.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class pp : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.ProductInfo", "StartTime", c => c.DateTime(nullable: false, precision: 0));
            AlterColumn("dbo.ProductInfo", "EndTime", c => c.DateTime(nullable: false, precision: 0));
        }
        
        public override void Down()
        {
            AlterColumn("dbo.ProductInfo", "EndTime", c => c.DateTime(precision: 0));
            AlterColumn("dbo.ProductInfo", "StartTime", c => c.DateTime(precision: 0));
        }
    }
}
