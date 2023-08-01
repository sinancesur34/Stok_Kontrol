using DataAccessLayer.Concrete.Repositories;
using EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.Concrete
{
    public class CategoryManager
    {
        GenericRepository<Kategori> repo = new GenericRepository<Kategori>();

        public List<Kategori> GetAllBl()
        {
            return repo.List();
        }
        public void KategoriAddBL(Kategori p)
        {
            repo.Insert(p);
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
