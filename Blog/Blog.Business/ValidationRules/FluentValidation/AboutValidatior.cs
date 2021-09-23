using Blog.Entities.Concrete;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Blog.Business.ValidationRules.FluentValidation
{
    public class AboutValidatior:AbstractValidator<About>
    {
        public AboutValidatior()
        {
            RuleFor(about => about.AboutFirstDetails)
                .NotEmpty().WithMessage("Hakkındanın İlk Detayı Boş Geçilemez")
                .NotNull().WithMessage("Hakkındanın İlk Detayı Boş Geçilemez")
                .MinimumLength(2).WithMessage("Hakkındanın İlk Detayı 2 Karakterden Küçük Olamaz")
                .MinimumLength(100).WithMessage("Hakkındanın İlk Detayı 100 Karakterden Büyük Olamaz");

            RuleFor(about=>about.AboutSecondDetails)
                .NotEmpty().WithMessage("Hakkındanın İkinci Detayı Boş Geçilemez")
                .NotNull().WithMessage("Hakkındanın İkinci Detayı Boş Geçilemez")
                .MinimumLength(2).WithMessage("Hakkındanın İkinci Detayı 2 Karakterden Küçük Olamaz")
                .MinimumLength(100).WithMessage("Hakkındanın İkinci Detayı 100 Karakterden Büyük Olamaz");
        }
    }
}
