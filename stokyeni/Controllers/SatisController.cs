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
    public class SatisController : Controller
    {

        SatisManager sm = new SatisManager(new EFSatisDal());
        MusteriManager mum = new MusteriManager(new EFMusteriDal());
        UrunManager um = new UrunManager(new EFUrunDal());
        KategoriManager km = new KategoriManager(new EFKategoriDal());

       

        public ActionResult Index()
        {
            var Satisvalues = sm.GetList();
            return View(Satisvalues);
        }

        [HttpGet]
        public ActionResult AddSatis()
        {
            List<SelectListItem> valueMusteri = (from x in mum.GetList()
                                                  select new SelectListItem
                                                  {
                                                      Text = x.MusteriAd + "  " + x.MusteriSoyad + "  " + x.MusteriTCKN,
                                                      Value = x.MusteriID.ToString()

                                                  }
                                                   ).ToList();
            ViewBag.vlm = valueMusteri;
            



            List<SelectListItem> valueUrun = (from x in um.GetList()
                                                 select new SelectListItem
                                                 {
                                                     Text = x.UrunAd + "  " + x.Marka +"  "+ x.Kategori.KategoriAd,
                                                     Value = x.UrunID.ToString()

                                                 }
                                                    ).ToList();
            ViewBag.vlu = valueUrun;
          

            return View();
        }

        [HttpPost]
        public ActionResult AddSatis(Satis p)
        {
            //cm.EFSatisService(p);
            SatisValidator SatisValidator = new SatisValidator();
            ValidationResult results = SatisValidator.Validate(p);


            if (results.IsValid)
            {
                p.Tarih = DateTime.Now;

                sm.SatisAdd(p);
                return RedirectToAction("index");
            }
            else

            {
                foreach (var item in results.Errors)
                {

                    ModelState.AddModelError(item.PropertyName, item.ErrorMessage);
                }
            }


            return View(); 

        }
        public ActionResult DeleteSatis(int id) //ayrı bir sayfa yapmayacagız indexte sil yapacagız.
        {
            var satisvalue = sm.GetByID(id);
            sm.SatisDelete(satisvalue);
            return RedirectToAction("index"); //indexe gönderdik
        }

        [HttpGet]
        public ActionResult EditSatis(int id)
        {

            List<SelectListItem> satiseditMusteri = (from x in mum.GetList()
                                                     select new SelectListItem
                                                     {
                                                         Text = x.MusteriAd + "  " + x.MusteriSoyad + "  " + x.MusteriTCKN,
                                                         Value = x.MusteriID.ToString()

                                                     }
                                   ).ToList();
            ViewBag.vlq = satiseditMusteri;



            List<SelectListItem> geturun = (from x in um.GetList()
                                              select new SelectListItem
                                              {
                                                  Text = x.UrunAd + "  " + x.Marka + "  " + x.Kategori.KategoriAd,
                                                  Value = x.UrunID.ToString()

                                              }
                                                    ).ToList();
            ViewBag.vlg = geturun;

            var satisvalue = sm.GetByID(id);
            return View(satisvalue);
        }

        [HttpPost]
        public ActionResult EditSatis(Satis p)
        {




            sm.SatisUpdate(p);
            return RedirectToAction("index");
        }
    }
}










//// GET: Category
//public ActionResult Index()
//{
//    return View();
//}

//public ActionResult GetSatisList()
//{
//    var Satisvalues = mum.GetAll();
//    return View(Satisvalues);
//}

//[HttpGet]
//public ActionResult AddSatis()
//{
//    return View();
//}

//[HttpPost]
//public ActionResult AddSatis(Satis p)
//{
//    mum.SatisAdd(p);
//    return RedirectToAction("GetSatisList");
//        }

//    }
//}


