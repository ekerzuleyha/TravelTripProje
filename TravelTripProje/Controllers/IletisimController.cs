using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using TravelTripProje.Models.Siniflar;

namespace TravelTripProje.Controllers
{
    public class IletisimController : Controller
    {
        Context c = new Context();
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult MesajAl(iletisim gelen)
        {
            c.iletisims.Add(gelen);
            c.SaveChanges();
            return RedirectToAction("Index");
        }
    }
}