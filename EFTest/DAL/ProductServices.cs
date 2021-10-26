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
                m.Database.Log = WriteLog;
                return m.ProductInfos.Where(t => t.PSN == productInfo.PSN).FirstOrDefault();
                //return m.ProductInfos.Find(productInfo.PSN);
            }
        }

        public static int UpdateProductInfo(Models.ProductInfo productInfo)
        {
            int index = 0;
            using (MyDbContext m = new MyDbContext())
            {
                m.Database.Log = WriteLog;
                using (var t = m.Database.BeginTransaction())
                {
                    // 方式1 会修改全部属性值
                    //var e = m.Entry(productInfo);
                    //e.State = System.Data.Entity.EntityState.Modified;

                    // 方式2 先查询，再修改
                    var data = m.ProductInfos.Where(tt => tt.PSN == productInfo.PSN).FirstOrDefault();

                    foreach (var old in data.GetType().GetProperties())
                    {
                        if (old.PropertyType == typeof(DateTime)) continue;
                        foreach (var new1 in productInfo.GetType().GetProperties())
                        {
                            if (new1.PropertyType == typeof(DateTime)) continue;
                            if (old.Name == new1.Name && 
                                new1.GetValue(productInfo) != default && 
                                old.GetValue(data) != new1.GetValue(productInfo))
                            {
                                if (new1.PropertyType == typeof(bool) && false != (bool)new1.GetValue(productInfo))
                                {
                                    old.SetValue(data, new1.GetValue(productInfo));
                                }
                                else if(new1.PropertyType != typeof(bool))
                                {
                                    old.SetValue(data, new1.GetValue(productInfo));
                                }
                            }
                        }
                        
                    }

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
                m.Database.Log = WriteLog;
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


        private static void WriteLog(string str)
        {
            Console.Write(str);
            using (System.IO.FileStream fs = new System.IO.FileStream(@".\sql.txt",System.IO.FileMode.Append,System.IO.FileAccess.Write))
            {
                byte[] vs = Encoding.UTF8.GetBytes(str);
                fs.Write(vs, 0, vs.Length);
            }
        }
    }
}
