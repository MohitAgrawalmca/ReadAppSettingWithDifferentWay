using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ConfigurationNet5.Sample
{
    public class Program
    {
        public static void Main(string[] args)
        {
            CreateHostBuilder(args).Build().Run();
        }

        public static IHostBuilder CreateHostBuilder(string[] args) =>
            Host.CreateDefaultBuilder(args)
            //This is how you attach additional JSON files
            .ConfigureAppConfiguration((hostingContext, config) =>
            {
                config.AddJsonFile("FileSettings.json", optional: false, reloadOnChange: false);
            })
            .ConfigureWebHostDefaults(webBuilder =>
                {
                    webBuilder.UseStartup<Startup>();
                    //.ConfigureAppConfiguration(c =>
                    //    c.AddJsonFile("FileSettings.json")); //Another way to add read config
                });
    }
}
