using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace EntityLayer.Concrete
{
    public class Musteri
    {
        [Key]
        public int MusteriID { get; set; }

        [StringLength(50)]
        public string MusteriAd { get; set; }

        [StringLength(50)]
        public string MusteriSoyad { get; set; }

        public int MusteriTCKN { get; set; }

        // Müşi ile Satışlarasında bir ilişki
        public virtual ICollection<Satis> Satislar { get; set; }
    }
}


