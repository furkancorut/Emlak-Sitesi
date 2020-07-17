using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace projestaj.Models.Sınıflar
{
    public class Portfolio
    {
        [Key]
        public int IDport { get; set; }

        public string Baslik { get; set; }
        public string Metrekare { get; set; }
        public string OdaSayısı { get; set; }
        public string Wc { get; set; }
        public string Detay4 {get;set;}

        public string Açiklama { get; set; }

        public ResimPath ResimPath { get; set; }


    }
}