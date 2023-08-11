using BusinessLayer.Concrete;
using BusinessLayer.ValidationRulers_fluentValidation;
using DataAccessLayer.EntityFramework;
using EntityLayer.Concrete;
using FluentValidation.Results;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Web;
using System.Web.Helpers;
using System.Web.Mvc;

namespace stokyeni.Controllers
{
    public class AdminKategoriController : Controller
    {

        KategoriManager km = new KategoriManager(new EFKategoriDal());
        // GET: AdminKategori
        public ActionResult Index()
        {
            var Kategorivalues = km.GetList();
            return View(Kategorivalues);
        }

        [HttpGet]
        public ActionResult AddCategory()
        {
            return View();
        }

        [HttpPost]
        public ActionResult AddCategory(Kategori p)
        {
            KategoriValidator KategoriValidator = new KategoriValidator();
            ValidationResult results = KategoriValidator.Validate(p);
            if (results.IsValid)
            {

                km.KategoriAdd(p);
                return RedirectToAction("Index");
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
        public ActionResult DeleteKategori(int id) //ayrı bir sayfa yapmayacagız indexte sil yapacagız.
        {
            var kategorivalue = km.GetByID(id);
            km.KategoriDelete(kategorivalue);
            return RedirectToAction("index"); //indexe gönderdik
        }

        [HttpGet]
        public ActionResult EditKategori(int id)
        {
            var kategorivalue = km.GetByID(id);
            return View(kategorivalue);
        }

        [HttpPost]
        public ActionResult EditKategori(Kategori p)
        {
            km.KategoriUpdate(p);
            return RedirectToAction("index");
        }
    }
}