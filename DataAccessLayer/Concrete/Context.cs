using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EntityLayer.Concrete;


namespace DataAccessLayer.Concrete
{
    public class Context:DbContext
    {

        public DbSet<Urun> Uruns { get; set; }
        public DbSet<Kategori> Kategoris { get; set; }
        public DbSet<Satis> Satis { get; set; }
        public DbSet<Musteri> Musteris { get; set; }


    }
}
