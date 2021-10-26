namespace EFTest.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class init : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.ProductInfo",
                c => new
                    {
                        PSN = c.String(nullable: false, maxLength: 50, storeType: "nvarchar"),
                        T1Data = c.String(maxLength: 50, storeType: "nvarchar"),
                        T1Result = c.Boolean(),
                        T2Data = c.String(maxLength: 50, storeType: "nvarchar"),
                        T2Result = c.Boolean(),
                        T3Data = c.String(maxLength: 50, storeType: "nvarchar"),
                        T3Result = c.Boolean(),
                        StartTime = c.DateTime(precision: 0),
                        EndTime = c.DateTime(precision: 0),
                    })
                .PrimaryKey(t => t.PSN);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.ProductInfo");
        }
    }
}
