using BusinessLayer.Concrete;
using DataAccessLayer.EntityFramework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
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
    }
}