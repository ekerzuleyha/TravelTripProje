using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace TravelTripProje.Models.Siniflar
{
    //bloglara yapılan yorumları tutan sayfa
    public class BlogYorum
    {
        //hangi tablolarımdan işlem gerçekleştireceksem onları enumarable olarak yazmam gerekir. bu da belli sayıdaki değerleri bir koleksiyon formatında toplayan yapıdır. 
        //IEnumarable sayesinde bir view içinde birden fazla tablodan değer çekebileceğiz.
        public IEnumerable<Blog> Deger1 { get; set; }
        //yorumları da deger2 olarak aldık.
        public IEnumerable<Yorumlar> Deger2 { get; set; }

        public IEnumerable<Blog> Deger3 { get; set; }

        public IEnumerable<Yorumlar> Deger4 { get; set; }

    }
}