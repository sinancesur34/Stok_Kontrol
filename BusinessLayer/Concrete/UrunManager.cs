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
    public class UrunManager : IUrunService
    {
        IUrunDal _UrunDal;



        public UrunManager(IUrunDal UrunDal)
        {
            _UrunDal = UrunDal;
        }


        public void UrunAdd(Urun Urun)
        {
            _UrunDal.Insert(Urun);
        }

        public List<Urun> GetList()
        {
            return _UrunDal.List();
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

        public void UrunDelete(Urun urun)
        {
            _UrunDal.Delete(urun);
        }

        public void UrunUpdate(Urun urun)
        {
            _UrunDal.Update(urun);
        }

        public Urun GetByID(int id)
        {
            return _UrunDal.Get(x => x.UrunID == id);
        }


        //ctrl+k+d   satırları düzenlemeye yarıyor

    }
}
