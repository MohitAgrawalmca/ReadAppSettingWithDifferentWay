using ConfigurationNet5.Sample.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Logging;
using Microsoft.Extensions.Options;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;

namespace ConfigurationNet5.Sample.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private Setting _Setting;
        public HomeController(ILogger<HomeController> logger, IOptions<Setting> options, IConfiguration  configuration )
        {
            _logger = logger;
            _Setting = options.Value;

            // Type2
            string config4 =  configuration["Settings:Config4"];

            // Type3
            string Version = configuration.GetSection("Version").Value;
            // Type4
            Version = configuration.GetValue<string>("Version");

            // Type5
            config4 = configuration.GetSection("Settings").GetSection("Config4").Value;

            Console.Write(config4);
        }

        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
