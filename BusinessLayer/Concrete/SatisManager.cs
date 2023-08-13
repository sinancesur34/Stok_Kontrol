using BusinessLayer.Abstract;
using DataAccessLayer.Abstract;
using DataAccessLayer.Concrete.Repositories;
using DataAccessLayer.EntityFramework;
using EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.Concrete
{
    public class SatisManager:ISatisService
    {
        ISatisDal _SatisDal;



        public SatisManager(ISatisDal SatisDal)
        {
            _SatisDal = SatisDal;
        }


        public void SatisAdd(Satis Satis)
        {
            _SatisDal.Insert(Satis);
        }

        public List<Satis> GetList()
        {
            return _SatisDal.List();
            //repo.Insert(p);
            //if (p.CategoryName == "" || p.CategoryName.Length <= 3 ||
            //   p.CategoryDescription == "" || p.CategoryName.Length >= 51)
            //{
            //    //hata mesajı
            //}
            //else
            //{

            //}
        }

        public void SatisDelete(Satis satis)
        {
           _SatisDal.Delete(satis);
        }

        public void SatisUpdate(Satis satis)
        {
           _SatisDal.Update(satis);
        }

        public Satis GetByID(int id)
        {
            return _SatisDal.Get(x => x.SatisID == id);
        }


        //ctrl+k+d   satırları düzenlemeye yarıyor

    }
}
