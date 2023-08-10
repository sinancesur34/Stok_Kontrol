using BusinessLayer.Abstract;
using DataAccessLayer.Abstract;
using DataAccessLayer.Concrete.Repositories;
using EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.ComponentModel.Design;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.Concrete
{
    public class KategoriManager :IKategoriService
    {

        IKategoriDal _KategoriDal;

      

        public KategoriManager(IKategoriDal KategoriDal)
        {
            _KategoriDal = KategoriDal;
        }


        public void KategoriAdd(Kategori kategori)
        {
            _KategoriDal.Insert(kategori);
        }

        public List<Kategori> GetList()
        {
            return _KategoriDal.List();
        }

        public Kategori GetByID(int id)
        {
            return _KategoriDal.Get(x => x.KategoriID == id); //kategori değerim ıd ile eşit olmalı. Lamda 
        }

        public void KategoriDelete(Kategori kategori)
        {
            _KategoriDal.Delete(kategori);
        }

        public void KategoriUpdate(Kategori kategori)
        {
            _KategoriDal.Update(kategori);
        }
    }
}
