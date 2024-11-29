using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using TravelTripProje.Models.Siniflar;

namespace TravelTripProje.Controllers
{
    public class BlogController : Controller
    {
        BlogYorum by = new BlogYorum();
        Context c = new Context();
        // GET: Blog

        public ActionResult BlogIndex()
        {
            //aynı tablo uzerinden 2 tane listeleme eşlem yaptığımız için ıenumarable kullandık.
            //var values = c.Blogs.ToList();
            by.Deger1 =c.Blogs.ToList();
            by.Deger3 = c.Blogs.OrderByDescending(x => x.ID).Take(3).ToList();
            by.Deger4 = c.Yorumlars.OrderByDescending(x => x.ID).Take(3).ToList();
            return View(by);
        }

        
        public ActionResult BlogDetay(int id)
        {
            ////bulunacak blog= bloglar içerisinde blog id si dışarıdan göndermiş olduğum parametrenin id sine eşit olan blogun listesini getir. ve geriye de bana bu bulmuş olduğum blogu döndür.
            //var blogbul = c.Blogs.Where(x=>x.ID==id).ToList();
            //return View(blogbul);

            //ilgili alanımız için değer ataması yaptık.
            by.Deger1 = c.Blogs.Where(x => x.ID == id).ToList();
            by.Deger2 = c.Yorumlars.Where(x => x.Blogid == id).ToList();
            return View(by);


        }
    }
}