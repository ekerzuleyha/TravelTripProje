using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using TravelTripProje.Models.Siniflar;

namespace TravelTripProje.Controllers
{
    public class BizeUlasınController : Controller
    {
        Context c = new Context();
        public ActionResult Index()
        {
            var dg = c.BizeUlasıns.ToList();
            return View(dg);
        }
    }
}