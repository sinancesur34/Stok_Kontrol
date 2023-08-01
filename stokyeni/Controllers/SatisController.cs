using BusinessLayer.Concrete;
using EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;


namespace tekrar_100ders.Controllers
{
    public class SatisController : Controller
    {

        SatisManager sm = new SatisManager();

        // GET: Category
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult GetSatisList()
        {
            var Satisvalues = sm.GetAllBl();
            return View(Satisvalues);
        }

        [HttpGet]
        public ActionResult AddSatis()
        {
            return View();
        }

        [HttpPost]
        public ActionResult AddSatis(Satis p)
        {
            sm.SatisAddBL(p);
            return RedirectToAction("GetSatisList");
        }

    }
}


