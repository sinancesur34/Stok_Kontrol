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


        //ctrl+k+d   satırları düzenlemeye yarıyor

    }
}


//    public class UrunManager
//    {
//        GenericRepository<Urun> repo = new GenericRepository<Urun>();

//        public List<Urun> GetAllBl()
//        {
//            return repo.List();
//        }
//        public void UrunAddBL(Urun p)
//        {
//            repo.Insert(p);
//            //if (p.CategoryName == "" || p.CategoryName.Length <= 3 ||
//            //   p.CategoryDescription == "" || p.CategoryName.Length >= 51)
//            //{
//            //    //hata mesajı
//            //}
//            //else
//            //{

//            //}
//        }


//        //ctrl+k+d   satırları düzenlemeye yarıyor

//    }
//}
