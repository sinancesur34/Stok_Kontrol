using BusinessLayer.Concrete;
using EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;


namespace tekrar_100ders.Controllers
{
    public class MusteriController : Controller
    {

        MusteriManager mum = new MusteriManager();

        // GET: Category
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult GetMusteriList()
        {
            var Musterivalues = mum.GetAllBl();
            return View(Musterivalues);
        }

        [HttpGet]
        public ActionResult AddMusteri()
        {
            return View();
        }

        [HttpPost]
        public ActionResult AddMusteri(Musteri p)
        {
            mum.MusteriAddBL(p);
            return RedirectToAction("GetMusteriList");
        }

    }
}


