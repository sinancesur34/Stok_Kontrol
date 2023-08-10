using DataAccessLayer.Abstract;
using EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.Abstract
{
    public interface IKategoriService

    {
        List<Kategori> GetList();


        void KategoriAdd(Kategori kategori);

        Kategori GetByID(int id); //getByID terimi genellikle bir nesnenin veya kaydın benzersiz kimliğini temel alarak veritabanından veya bir veri kaynağından belirli bir öğeyi almak veya getirmek için kullanılan bir fonksiyon veya yöntemi ifade eder.
                                  //bunu buraya tanımladıktan sonra kategori managerde de implement etmemiz gerek.
        void KategoriDelete(Kategori kategori);
        void KategoriUpdate(Kategori kategori);
    }

}

