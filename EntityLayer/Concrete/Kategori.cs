using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace EntityLayer.Concrete
{
    public class Kategori
    {
        [Key]
      
        public int KategoriID { get; set; }



        [StringLength(50)]
        public string KategoriAd { get; set; }

        // Kategori ile Ürünler arasında bir ilişki
        public virtual ICollection<Urun> Urunler { get; set; }

      
    }
}