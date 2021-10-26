namespace EFTest.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class update : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.ProductInfo", "T1Result", c => c.Boolean(nullable: false));
            AlterColumn("dbo.ProductInfo", "T2Result", c => c.Boolean(nullable: false));
            AlterColumn("dbo.ProductInfo", "T3Result", c => c.Boolean(nullable: false));
        }
        
        public override void Down()
        {
            AlterColumn("dbo.ProductInfo", "T3Result", c => c.Boolean());
            AlterColumn("dbo.ProductInfo", "T2Result", c => c.Boolean());
            AlterColumn("dbo.ProductInfo", "T1Result", c => c.Boolean());
        }
    }
}
