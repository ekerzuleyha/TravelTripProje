using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace TravelTripProje.Controllers
{
    //default controller bir takım değerlerini controller sınıfından miras alıyor.
    public class DefaultController : Controller
    {
        // GET: Default
        public ActionResult Index()
        {
            //geriye bir tane sayfa döndürüyor.
            return View();
        }

        public ActionResult About()
        {
            
            return View();
        }
    }
}