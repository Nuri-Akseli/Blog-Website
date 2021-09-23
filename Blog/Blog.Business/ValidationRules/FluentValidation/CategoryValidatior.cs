using Blog.Entities.Concrete;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Blog.Business.ValidationRules.FluentValidation
{
    public class CategoryValidatior:AbstractValidator<Category>
    {
        public CategoryValidatior()
        {
            RuleFor(category => category.CategoryName)
                .NotNull().WithMessage("Kategori Adı Boş Geçilemez")
                .NotEmpty().WithMessage("Kategori Adı Boş Geçilemez")
                .MinimumLength(2).WithMessage("Kategori Adı 2 Karakterden Büyük Olmalıdır")
                .MaximumLength(20).WithMessage("Kategori Adı 20 Karakterden Büyük Olamaz");

            RuleFor(category => category.CategoryDescription)
                .NotEmpty().WithMessage("Kategori Açıklaması Boş Geçilemez")
                .NotNull().WithMessage("Kategori Açıklaması Boş Geçilemez")
                .MaximumLength(50).WithMessage("Kategori Açıklaması En Fazla 50 Karakter Olabilir")
                .MinimumLength(5).WithMessage("Kategori Açıklaması 5 Karakterden Az Olamaz");

        }
    }
}
