namespace EFTest.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class removeDate : DbMigration
    {
        public override void Up()
        {
            DropColumn("dbo.ProductInfo", "Date");
        }
        
        public override void Down()
        {
            AddColumn("dbo.ProductInfo", "Date", c => c.DateTime(nullable: false, storeType: "date"));
        }
    }
}
