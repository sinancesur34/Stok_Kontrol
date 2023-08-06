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
    public class SatisController : Controller
    {

        SatisManager sm = new SatisManager(new EFSatisDal());

        // GET: Category
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult GetSatisList()
        {
            var satisvalues = sm.GetList();
            return View(satisvalues);
        }

        [HttpGet]
        public ActionResult AddSatis()
        {
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
                sm.SatisAdd(p);
                return RedirectToAction("GetSatisList");
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



