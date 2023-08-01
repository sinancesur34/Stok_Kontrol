using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace EntityLayer.Concrete
{
    public class Kategori
    {
       
        public int KategoriID { get; set; }

        [StringLength(50)]

        [Key]
        public string KategoriAd { get; set; }

        // Kategori ile Ürünler arasında bir ilişki
        public virtual ICollection<Urun> Urunler { get; set; }

      
    }
}