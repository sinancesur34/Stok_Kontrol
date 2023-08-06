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
    public class KategoriManager :IKategoriService
    {

        IKategoriDal _KategoriDal;

      

        public KategoriManager(IKategoriDal KategoriDal)
        {
            _KategoriDal = KategoriDal;
        }


        public void KategoriAdd(Kategori Kategori)
        {
            _KategoriDal.Insert(Kategori);
        }

        public List<Kategori> GetList()
        {
            return _KategoriDal.List();
        }


    }
}
