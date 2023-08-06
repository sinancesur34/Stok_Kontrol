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


namespace tekrar_100ders.Controllers
{
    public class MusteriController: Controller
    {

        MusteriManager mum = new MusteriManager(new EFMusteriDal());

        // GET: Category
        //public ActionResult Index()
        //{
        //    return View();
        //}

        public ActionResult GetMusteriList()
        {
            var Musterivalues = mum.GetList();
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
            //cm.EFMusteriService(p);
            MusteriValidator MusteriValidator = new MusteriValidator();
            ValidationResult results = MusteriValidator.Validate(p);


            if (results.IsValid)
            {
                mum.MusteriAdd(p);
                return RedirectToAction("GetMusteriList");
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










            //// GET: Category
            //public ActionResult Index()
            //{
            //    return View();
            //}

            //public ActionResult GetMusteriList()
            //{
            //    var Musterivalues = mum.GetAll();
            //    return View(Musterivalues);
            //}

            //[HttpGet]
            //public ActionResult AddMusteri()
            //{
            //    return View();
            //}

            //[HttpPost]
            //public ActionResult AddMusteri(Musteri p)
            //{
            //    mum.MusteriAdd(p);
            //    return RedirectToAction("GetMusteriList");
//        }

//    }
//}


