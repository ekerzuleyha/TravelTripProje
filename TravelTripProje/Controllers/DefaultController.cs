using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using TravelTripProje.Models.Siniflar;

namespace TravelTripProje.Controllers
{
    //default controller bir takım değerlerini controller sınıfından miras alıyor.
    public class DefaultController : Controller
    {
        // GET: Default
        Context c = new Context();

        public ActionResult Index()
        {
            var values = c.Blogs.Take(4).ToList();
            //geriye bir tane sayfa döndürüyor.
            return View(values);
        }

        public ActionResult About()
        {
            
            return View();
        }

        public PartialViewResult Partial1()
        {
            var degerler = c.Blogs.OrderByDescending(x => x.ID).Take(2).ToList();
            return PartialView(degerler);
        }

        public PartialViewResult Partial11()
        {
            //var deger = c.Blogs.OrderByDescending(x => x.ID).Take(1).ToList();
            var deger = c.Blogs.Where(x => x.ID == 1).ToList();
            return PartialView(deger);
        }

        public PartialViewResult Partial3()
        {
            var deger = c.Blogs.ToList();
            return PartialView(deger); 
        }

        public PartialViewResult Partial4()
        {
            var deger = c.Blogs.OrderBy(x => x.ID).Take(3).ToList();
            return PartialView(deger);
        }

        public PartialViewResult Partial5()
        {
            var deger = c.Blogs.OrderByDescending(x => x.ID).Take(3).ToList();
            return PartialView(deger);
        }
    }
}