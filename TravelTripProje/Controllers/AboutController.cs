using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TravelTripProje.Models.Siniflar;

namespace TravelTripProje.Controllers
{
    public class AboutController : Controller
    {
        Context context = new Context();
        public IActionResult Index()
        {
            var degerler = context.Hakkimizdas.ToList();
            return View(degerler);
        }
    }
}
