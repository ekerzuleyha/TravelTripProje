using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace TravelTripProje.Models.Siniflar
{
    public class BizeUlasın
    {
        [Key]
        public int Id { get; set; }
        public string Adres { get; set; }
        public string Mail { get; set; }
        public string Telefon { get; set; }
    }
}