using Blog.Entities.Concrete;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Blog.Business.ValidationRules.FluentValidation
{
    public class ArticleValidatior:AbstractValidator<Article>
    {
        public ArticleValidatior()
        {
            RuleFor(article => article.ArticleContent)
                .NotEmpty().WithMessage("İçerik Boş Geçilemez")
                .MaximumLength(1000).WithMessage("İçerik En Fazla 1000 Karakter Olabilir")
                .MinimumLength(100).WithMessage("İçerik 100 Karakterden Fazla Olmalıdır");

            RuleFor(article => article.ArticleTitle)
                .NotEmpty().WithMessage("Başlık Boş Geçilemez")
                .MinimumLength(2).WithMessage("Başlık 2 Karakterden Fazla Olmalıdır")
                .MaximumLength(20).WithMessage("Başlık En Fazla 20 Karakter Olabilir");
        }
    }
}
