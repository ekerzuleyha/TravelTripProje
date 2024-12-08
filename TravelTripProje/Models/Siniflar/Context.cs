using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;


namespace TravelTripProje.Models.Siniflar
{
    //ilgili tablolarıma ulaşabilmek için dbcontext sınıfından miras almamız gerekiyor.
    public class Context:DbContext
    {
       public DbSet<Admin> Admind { get; set; }
       public DbSet<AdresBlog> AdresBlogs { get; set; }
       public DbSet<Blog> Blogs { get; set; }
       public DbSet<Hakkimizda> Hakkimizdas { get; set; }
       public DbSet<iletisim> iletisims { get; set; }
       public DbSet<Yorumlar> Yorumlars { get; set; }
       public DbSet<BizeUlasın> BizeUlasıns { get; set; }
      
    }
}