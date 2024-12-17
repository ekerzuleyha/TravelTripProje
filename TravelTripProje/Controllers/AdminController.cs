using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using TravelTripProje.Models.Siniflar;

namespace TravelTripProje.Controllers
{
    public class AdminController : Controller
    {
        Context c = new Context();
        
        public ActionResult Index()
        {
            var values = c.Blogs.ToList();
            return View(values);
        }

        [HttpGet]
        public ActionResult YeniBlog()
        {
            return View();
        }

        [HttpPost]
        public ActionResult YeniBlog(Blog blog)
        {
            c.Blogs.Add(blog);
            c.SaveChanges();
            return RedirectToAction("Index");
        }

        public ActionResult BlogSil(int id)
        {
            var deger = c.Blogs.Find(id);
            c.Blogs.Remove(deger);
            c.SaveChanges();
            return RedirectToAction("Index");
        }

        public ActionResult BlogGetir(int id)
        {
            var deger = c.Blogs.Find(id);
            //degerle birlikte blog getir sayfasını getir.
            return View("BlogGetir", deger);
        }

        public ActionResult BlogGüncelleme(Blog blog)
        {
            var deger = c.Blogs.Find(blog.ID);
            deger.Baslik = blog.Baslik;
            deger.Tarih = blog.Tarih;
            deger.Aciklama = blog.Aciklama;
            deger.BlogImage = blog.BlogImage;
            c.SaveChanges();
            return RedirectToAction("Index");
        }

        public ActionResult DetayGetir(int id)
        {
            var deger = c.Blogs.Find(id);
            return View(deger);
        }
        //[HttpGet]
        //public ActionResult BlogGüncelle(int id)
        //{
        //    var deger = c.Blogs.Find(id);
        //    return View(deger);
        //}

        //[HttpPost]
        //public ActionResult BlogGüncelle(Blog blog)
        //{
        //    var deger = c.Blogs.Find(blog.ID);
        //    deger.Baslik = blog.Baslik;
        //    deger.Tarih = blog.Tarih;
        //    deger.Aciklama = blog.Aciklama;
        //    deger.BlogImage = blog.BlogImage;
        //    c.SaveChanges();
        //    return RedirectToAction("Index");
        //}

        public ActionResult YorumListesi()
        {
            var yorumlar = c.Yorumlars.ToList();
            return View(yorumlar);
        }

        public ActionResult YorumSil(int id)
        {
            var deger = c.Yorumlars.Find(id);
            c.Yorumlars.Remove(deger);
            c.SaveChanges();
            return RedirectToAction("YorumListesi");
        }


        public ActionResult YorumGetir(int id)
        {
            var deger = c.Yorumlars.Find(id);
            return View("YorumGetir", deger);
        }

        public ActionResult YorumGüncelle(Yorumlar yorum)
        {
            var deger = c.Yorumlars.Find(yorum.ID);
            deger.KullaniciAdi = yorum.KullaniciAdi;
            deger.Mail = yorum.Mail;
            deger.Yorumm = yorum.Yorumm;
            c.SaveChanges();
            return RedirectToAction("YorumListesi");
        }

       
    }
}