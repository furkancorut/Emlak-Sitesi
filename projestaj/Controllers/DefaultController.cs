using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using projestaj.Models.Sınıflar;
namespace projestaj.Controllers
{
    public class DefaultController : Controller
    {
        //GET: Default 


        public ActionResult Index()
        {
            return View();
        }

        public ActionResult Sunulanİlan()
        {
            return View();
        }
        public ActionResult Blog()
        {
            return View();
        }
        public ActionResult İletisim()
        {
            return View();
        }
        public ActionResult About()
        {

            return View();
        }


        Context c = new Context();
        public ActionResult Sayfalar ()
        {
            var degerler = c.Portfolios.ToList();
            
            return View(degerler);
        }

        public ActionResult EvBilgisi ()
        {
            return View();
        }
        public ActionResult KayıtSayfası ()
        {
            return View();
        }

        public ActionResult Login ()
        {
            return View();
        }
    }
}
