using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace TravelTripProje.Models.Siniflar
{
    public class Yorumlar
    {
        [Key]
        public int ID { get; set; }
        public string KullaniciAdi { get; set; }
        public string Mail { get; set; }
        public string Yorumm { get; set; }
        //nu yorum hangi bloga yapıldı . bunu tutmak için yazdık. int olarak tuttuk.
        //public int BlogID { get; set; }
        //blog tablosundan blog isimli bir tane değer oluşturdum.
        public Blog Blog { get; set; }
    }
}