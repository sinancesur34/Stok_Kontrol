﻿using DataAccessLayer.Abstract;
using EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.Abstract
{
    public interface ISatisService
    {
        List<Satis> GetList();
        void SatisAdd(Satis satis);
        void SatisDelete(Satis satis);
        void SatisUpdate(Satis satis);
        Satis GetByID(int id);
    }
}
