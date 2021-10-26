namespace EFTest
{
    using System.Data.Entity;
    class MyDbContext :DbContext
    {
        
        public MyDbContext():base("MyConnectString")
        {
            
        }

        public IDbSet<Models.ProductInfo>  ProductInfos { get; set; }

        //public IDbSet<Models.EnumTestContext> EnumTestContexts { get; set; }

    }
}
