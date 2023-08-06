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
    public class MusteriManager:IMusteriService
    {

        IMusteriDal _MusteriDal;



        public MusteriManager(IMusteriDal MusteriDal)
        {
            _MusteriDal = MusteriDal;
        }


        public void MusteriAdd(Musteri Musteri)
        {
            _MusteriDal.Insert(Musteri);
        }

        public List<Musteri> GetList()
        {
            return _MusteriDal.List();
        }


        //ctrl+k+d   satırları düzenlemeye yarıyor

    }
}
