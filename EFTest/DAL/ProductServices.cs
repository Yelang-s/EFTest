using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EFTest.DAL
{
    class ProductServices
    {
        public static Models.ProductInfo GetProductInfo(Models.ProductInfo productInfo)
        {
            using (MyDbContext m = new MyDbContext())
            {
                //return m.ProductInfos.Where(t => t.PSN == productInfo.PSN).FirstOrDefault();
                return m.ProductInfos.Find(productInfo.PSN);
            }
        }

        public static int UpdateProductInfo(Models.ProductInfo productInfo)
        {
            int index = 0;
            using (MyDbContext m = new MyDbContext())
            {
                using (var t = m.Database.BeginTransaction())
                {
                    // 方式1 会修改全部属性值
                    //var e = m.Entry(productInfo);
                    //e.State = System.Data.Entity.EntityState.Modified;

                    // 方式2 先查询，再修改
                    var data = m.ProductInfos.Find(productInfo.PSN);
                    
                    index = m.SaveChanges();
                    t.Commit();
                }
            }
            return index;
        }

        public static int AddProductInfo(Models.ProductInfo[] productInfos)
        {
            int index = 0;
            using (MyDbContext m = new MyDbContext())
            {
                m.Database.Log = Console.Write;
                m.Configuration.AutoDetectChangesEnabled = false;
                using (var t = m.Database.BeginTransaction())
                {
                    foreach (Models.ProductInfo productInfo in productInfos)
                    {
                        m.ProductInfos.Add(productInfo);
                    }
                    index= m.SaveChanges();
                    t.Commit();
                }
                m.Configuration.AutoDetectChangesEnabled = true;
            }
            return index;
        }
    }
}
