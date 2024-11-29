using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using TravelTripProje.Models.Siniflar;

namespace TravelTripProje.Controllers
{
    public class AboutController : Controller
    {
        // GET: aBOUT
        //context sınıfından c isimli bir nesne türettik ve bu c sayesinde contextte bağlı olan sınıflarımız içerisinde hakkımızda tabloma ulaşıp bu tabloyu listeledik.
        Context c = new Context();

        public ActionResult Index()
        {
            var values = c.Hakkimizdas.ToList();
            return View(values);
        }
    }
}