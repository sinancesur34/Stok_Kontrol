using EntityLayer.Concrete;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.ValidationRulers_fluentValidation
{
    public class SatisValidator:AbstractValidator<Satis>
    {
        public SatisValidator()
        {
            RuleFor(x => x.UrunID).NotEmpty().WithMessage("Ürün Boş Olamaz");
            RuleFor(x => x.MusteriID).NotEmpty().WithMessage("Müşteri Boş Olamaz");
      

        }
       
    }
}
