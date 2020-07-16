using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace projestaj.Models.Sınıflar
{
    public class ResimPath
    {
        [Key]
        public string IDresim { get; set; }
        public string Path { get; set; }

   
        public List<Portfolio> Portfolios { get; set; }

    }
}