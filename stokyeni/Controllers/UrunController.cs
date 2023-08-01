using BusinessLayer.Concrete;
using EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Contexts;
using System.Web;
using System.Web.Mvc;

namespace stokyeni.Controllers
{
    public class UrunController : Controller
    {

        Context c = new Context();

        UrunManager um = new UrunManager();


        // GET: Musteri
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult GetUrunList()
        {
            var Urunvalues = um.GetAllBl();
            return View(Urunvalues);
        }

        [HttpGet]
        public ActionResult AddUrun()
        {
            //List<SelectListItem> values =( from i in c.Kategoris.ToList()
            //                               select new SelectListItem
            //                               {
            //                                   Text = i.KategoriAd,
            //                                   Value = i.KategoriID.ToString()


            //                               }); 
            //ViewBag.dgr = values;
            return View();
        }

        [HttpPost]
        public ActionResult AddUrun(Urun p)
        {
            um.UrunAddBL(p);
            return RedirectToAction("GetUrunList");
        }

    }
}






    