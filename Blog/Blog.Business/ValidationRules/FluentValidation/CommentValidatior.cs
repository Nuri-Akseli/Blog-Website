using Blog.Entities.Concrete;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Blog.Business.ValidationRules.FluentValidation
{
    public class CommentValidatior:AbstractValidator<Comment>
    {
        public CommentValidatior()
        {
            RuleFor(comment => comment.CommentTitle)
                .NotEmpty().WithMessage("Başlık Boş Geçilemez")
                .MinimumLength(3).WithMessage("Başlık 3 Karakterden Fazla Olmalıdır")
                .MinimumLength(20).WithMessage("Başlık 20 Karakterden Fazla Olamaz");

            RuleFor(comment => comment.CommentContent)
                .NotEmpty().WithMessage("Yorum Boş Geçilemez")
                .MinimumLength(5).WithMessage("Yorum 5 Karakterden Fazla Olmalıdır")
                .MaximumLength(100).WithMessage("Yorum En Fazla 100 Karakterden Oluşabilir");

            RuleFor(comment => comment.CommentUserName)
                .NotEmpty().WithMessage("Kullanıcı Adı Boş Geçilemez")
                .MinimumLength(2).WithMessage("Kullanıcı Adı 2 Karakterden Fazla Olmalıdır")
                .MaximumLength(20).WithMessage("Kullanıcı Adı En Fazla 20 Karakter Olabilir");

        }
    }
}
