using System.Diagnostics;

namespace EFTest
{
    class Program
    {
        static void Main(string[] args)
        {
            //DAL.ProductServices.AddProductInfo(new Models.ProductInfo[] {
            //    new Models.ProductInfo { PSN="12345", T1Data="1",T1Result=true,T2Data="2",T2Result=true,T3Data="3",T3Result=true,StartTime=System.DateTime.Now,EndTime= System.DateTime.Now},
            //    new Models.ProductInfo { PSN="23456", T1Data="1",T1Result=false,T2Data="2",T2Result=false,T3Data="3",T3Result=false,StartTime=System.DateTime.Now,EndTime= System.DateTime.Now} });

            //Models.ProductInfo productInfo = DAL.ProductServices.GetProductInfo(new Models.ProductInfo { PSN = "23456" });

            //for (int i = 0; i < 3; i++)
            //{
            //    var s = Stopwatch.StartNew();
            //    DAL.ProductServices.UpdateProductInfo(new Models.ProductInfo
            //    {
            //        PSN = "12345x",
            //        T1Data = $"12{i}.77",

            //        T2Data = $"14{i}6.7",
            //        T3Data = $"1{i}5.9"
            //    });
            //    System.Console.WriteLine(s.ElapsedMilliseconds);
            //    System.Console.WriteLine("Done");
            //}
            //var s = Stopwatch.StartNew();
            //DAL.ProductServices.UpdateProductInfo(new Models.ProductInfo
            //{
            //    PSN = "23456",
            //    T1Data = "124.77",

            //    T2Data = "14556.7",
            //    T3Data = "1995.9"
            //});
            //System.Console.WriteLine(s.ElapsedMilliseconds);
            System.Console.WriteLine("Done");
            System.Console.ReadLine();
        }
    }
}
