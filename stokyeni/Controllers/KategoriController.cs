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
    public class CategoryController : Controller
    {

        KategoriManager cm = new KategoriManager(new EFKategoriDal()); 

        // GET: Category
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult GetCategoryList()
        {
            var categoryvalues = cm.GetList();
            return View(categoryvalues);
        }

        [HttpGet]
        public ActionResult AddCategory()
        {
            return View();
        }

        [HttpPost]
        public ActionResult AddCategory(Kategori p)
        {
            //cm.EFKategoriService(p);
            KategoriValidator KategoriValidator = new KategoriValidator();
            ValidationResult results = KategoriValidator.Validate(p);


            if(results.IsValid)
                {
                cm.KategoriAdd(p);
                return RedirectToAction("GetCategoryList");
            }
            else
            
            {
                foreach (var item in results.Errors)
                    {

                    ModelState.AddModelError(item.PropertyName, item.ErrorMessage);
                }
            }

          
            return RedirectToAction("GetCategoryList");
        }

    } 
}


