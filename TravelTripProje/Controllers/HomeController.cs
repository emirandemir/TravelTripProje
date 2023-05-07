using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using TravelTripProje.Models;
using TravelTripProje.Models.Siniflar;
namespace TravelTripProje.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        Context context = new Context();
        public IActionResult Index()
        {
            var degerler = context.Blogs.ToList(); 
            return View(degerler);
        }

        public IActionResult About()
        {
            return View();
        }

        public PartialViewResult Partial1()
        {
            var degerler = context.Blogs.OrderByDescending(x => x.ID).Take(2).ToList();
            return PartialView(degerler);
        }
        public PartialViewResult Partial2()
        {
            var degerler2 = context.Blogs.Where(x => x.ID == 1).ToList();
            return PartialView(degerler2);
        }

        public PartialViewResult Partial3()
        {
            var degerler3 = context.Blogs.OrderBy(x => x.ID).ToList();
            return PartialView(degerler3);
        }


        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
