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

        public void MusteriDelete(Musteri musteri)
        {
            _MusteriDal.Delete(musteri);    
        }

        public void MusteriUpdate(Musteri musteri)
        {
            _MusteriDal.Update(musteri);
        }

        public Musteri GetByID(int id)
        {
            return _MusteriDal.Get(x => x.MusteriID == id);
        }


        //ctrl+k+d   satırları düzenlemeye yarıyor

    }
}
