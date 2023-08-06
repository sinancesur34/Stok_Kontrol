using BusinessLayer.Abstract;
using DataAccessLayer.Abstract;
using DataAccessLayer.Concrete.Repositories;
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


        //ctrl+k+d   satırları düzenlemeye yarıyor

    }
}
