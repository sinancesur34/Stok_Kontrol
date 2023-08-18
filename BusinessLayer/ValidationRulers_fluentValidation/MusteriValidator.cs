﻿using BusinessLayer.Concrete;
using EntityLayer.Concrete;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FluentValidation.Validators;

namespace BusinessLayer.ValidationRulers_fluentValidation
{
    public class MusteriValidator:AbstractValidator<Musteri>
    {
        public MusteriValidator()
        {
           RuleFor(x => x.MusteriTCKN).MinimumLength(11).WithMessage("11 hane giriniz ");
            RuleFor(x => x.MusteriTCKN).MaximumLength(11).WithMessage("11 hane giriniz ");
            //RuleFor(x => x.MusteriTCKN).("11 hane giriniz ");
            RuleFor(x => x.MusteriAd).NotEmpty().WithMessage("Müşteri Adı Boş Olamaz") ;
            RuleFor(x => x.MusteriSoyad).NotEmpty().WithMessage("Müşteri Soyadı Boş Olamaz");
            RuleFor(x => x.MusteriTCKN).NotEmpty().WithMessage("TC Kimlik No Boş Olamaz");
          



        }


     
    }
}

