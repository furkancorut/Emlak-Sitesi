using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;

namespace projestaj.Models.Sınıflar
{
    public class Context: DbContext
    {


        public DbSet<Kullanici> Kullanicis { get; set; }
        public DbSet<Portfolio> Portfolios { get; set; }

        public DbSet<ResimPath> ResimPaths { get; set; }


    }
}