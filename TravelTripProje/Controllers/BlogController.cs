using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TravelTripProje.Models.Siniflar;

namespace TravelTripProje.Controllers
{
    public class BlogController : Controller
    {
        Context context = new Context();
        BlogYorum by = new BlogYorum();
        public IActionResult Index()
        {
            by.Deger1 = context.Blogs.ToList();
            by.Deger3 = context.Blogs.OrderByDescending(x => x.ID).Take(3).ToList();//son 3 bloğu çagırıyoruz.
            //var bloglar = context.Blogs.ToList();
            return View(by.Deger3);
        }
        public IActionResult BlogDetay(int id)
        {
            by.Deger1 = context.Blogs.Where(x => x.ID == id).ToList();
            by.Deger2 = context.yorumlars.Where(x => x.Blogid == id).ToList(); 
            //var blogbul = context.Blogs.Where(x => x.ID == id).ToList();
            return View(by);
        }
    }
}
