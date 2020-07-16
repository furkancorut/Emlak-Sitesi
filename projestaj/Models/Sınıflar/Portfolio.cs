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

        public string Baslik { get; set;}
        public string Detay1 { get; set; }
        public string Detay2 { get; set; }
        public string Detay3 { get; set; }

        public ResimPath ResimPath { get; set; }


    }
}