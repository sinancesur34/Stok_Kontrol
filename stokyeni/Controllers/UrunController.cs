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
//using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace stokyeni.Controllers
{
    public class UrunController : Controller
    {

        UrunManager um = new UrunManager(new EFUrunDal());

        // GET: Category
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult GetUrunList()
        {
            var Urunvalues = um.GetList();
            return View(Urunvalues);
        }

        [HttpGet]
        public ActionResult AddUrun()
        {
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
                return RedirectToAction("GetUrunList");
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

    }
}







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






