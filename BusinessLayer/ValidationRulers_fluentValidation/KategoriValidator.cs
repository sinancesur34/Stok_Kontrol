using EntityLayer.Concrete;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.ComponentModel.Design;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.ValidationRulers_fluentValidation
{
    public class KategoriValidator : AbstractValidator<Kategori>
    {
        public KategoriValidator()
        {
            RuleFor(x => x.KategoriAd).NotEmpty().WithMessage("Kategori Adı Boş Olamaz");


            //RuleFor(x => x.KategoriAd)
            //   .Must((Kategori, KategoriAd) => IsUniqueKategoriAd(KategoriAd))
            //   .WithMessage("Bu kullanıcı adı daha önce kullanıldı.");

        }







        //public void KategoriAdd(Kategori p)
        //{
        //    throw new NotImplementedException();
        //}
    }
}

