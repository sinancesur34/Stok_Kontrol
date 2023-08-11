﻿using EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer.Abstract
{
    public interface IKategoriDal : IRepository<Kategori>
    {
        void Update(Kategori kategori);
    }
}
