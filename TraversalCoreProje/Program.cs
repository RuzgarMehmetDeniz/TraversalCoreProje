using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Hosting;
using OfficeOpenXml;  // EPPlus namespace

namespace TraversalCoreProje
{
    public class Program
    {
        public static void Main(string[] args)
        {
            ExcelPackage.License.SetNonCommercialPersonal("Ýsminiz");

            CreateHostBuilder(args).Build().Run();
        }

        public static IHostBuilder CreateHostBuilder(string[] args) =>
            Host.CreateDefaultBuilder(args)
                .ConfigureWebHostDefaults(webBuilder =>
                {
                    webBuilder.UseStartup<Startup>();
                });
    }
}
