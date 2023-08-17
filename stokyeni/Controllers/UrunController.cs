using BusinessLayer.Concrete;
using BusinessLayer.ValidationRulers_fluentValidation;
using DataAccessLayer.EntityFramework;
using EntityLayer.Concrete;
using FluentValidation;
using FluentValidation.Results;
using Microsoft.Ajax.Utilities;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Web;
using System.Web.Mvc;


namespace tekrar_100ders.Controllers
{
    public class UrunController : Controller
    {

        UrunManager um = new UrunManager(new EFUrunDal());
        KategoriManager km = new KategoriManager(new EFKategoriDal());   //İD ler ile isimlerini göstermek için kullanıyoruz

        // GET: Category
        //public ActionResult Index()
        //{
        //    return View();
        //}

        public ActionResult Index()
        {
            var Urunvalues = um.GetList();
            return View(Urunvalues);
        }

        [HttpGet]
        public ActionResult AddUrun()
        {
            List<SelectListItem> valuekategori = (from x in km.GetList()
                                                  select new SelectListItem
                                                  {
                                                      Text = x.KategoriAd,
                                                      Value = x.KategoriID.ToString()

                                                  }
                                                ).ToList();
            ViewBag.vlk=valuekategori;
            return View();
        }

        [HttpPost]
        public ActionResult AddUrun(Urun p)
        {
            //cm.EFUrunService(p);
            UrunValidator UrunValidator = new UrunValidator();
            ValidationResult results = UrunValidator.Validate(p);


            if (results.IsValid)
            {
                um.UrunAdd(p);
                return RedirectToAction("index");
            }
            else

            {
                foreach (var item in results.Errors)
                {

                    ModelState.AddModelError(item.PropertyName, item.ErrorMessage);
                }
            }


            return View(); /*RedirectToAction("GetCategoryList");*/

        }
        public ActionResult DeleteUrun(int id) //ayrı bir sayfa yapmayacagız indexte sil yapacagız.
        {
            var urunvalue = um.GetByID(id);
            um.UrunDelete(urunvalue);
            return RedirectToAction("index"); //indexe gönderdik
        }

        [HttpGet]
        public ActionResult EditUrun(int id)

        {
            List<SelectListItem> degerkategori = (from x in km.GetList()
                                                  select new SelectListItem
                                                  {
                                                      Text = x.KategoriAd,
                                                      Value = x.KategoriID.ToString()

                                                  }
                                               ).ToList();
            ViewBag.vlc = degerkategori;


            var urunvalue = um.GetByID(id);
            return View(urunvalue);
        }

        [HttpPost]
        public ActionResult EditUrun(Urun p)
        {
            um.UrunUpdate(p);
            return RedirectToAction("index");
        }
    }
}










//// GET: Category
//public ActionResult Index()
//{
//    return View();
//}

//public ActionResult GetUrunList()
//{
//    var Urunvalues = mum.GetAll();
//    return View(Urunvalues);
//}

//[HttpGet]
//public ActionResult AddUrun()
//{
//    return View();
//}

//[HttpPost]
//public ActionResult AddUrun(Urun p)
//{
//    mum.UrunAdd(p);
//    return RedirectToAction("GetUrunList");
//        }

//    }
//}








//    public class UrunController : Controller
//    {

//        Context c = new Context();

//        UrunManager um = new UrunManager();


//        // GET: Musteri
//        public ActionResult Index()
//        {
//            return View();
//        }

//        public ActionResult GetUrunList()
//        {
//            var Urunvalues = um.GetAllBl();
//            return View(Urunvalues);
//        }

//        [HttpGet]
//        public ActionResult AddUrun()
//        {
//            //List<SelectListItem> values =( from i in c.Kategoris.ToList()
//            //                               select new SelectListItem
//            //                               {
//            //                                   Text = i.KategoriAd,
//            //                                   Value = i.KategoriID.ToString()


//            //                               }); 
//            //ViewBag.dgr = values;
//            return View();
//        }

//        [HttpPost]
//        public ActionResult AddUrun(Urun p)
//        {
//            um.UrunAddBL(p);
//            return RedirectToAction("GetUrunList");
//        }

//    }
//}






