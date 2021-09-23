using Blog.Entities.Concrete;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Blog.Business.ValidationRules.FluentValidation
{
    public class ContactValidatior:AbstractValidator<Contact>
    {
        public ContactValidatior()
        {
            RuleFor(contact => contact.ContactMail)
                .NotEmpty().WithMessage("Mail Kısmı Boş Geçilemez")
                .EmailAddress().WithMessage("E-mail Formatına Uygun Olmalıdır");

            RuleFor(contact => contact.ContactMessage)
                .NotEmpty().WithMessage("Mesaj Boş Geçilemez")
                .MinimumLength(5).WithMessage("Mesaj En Az 5 Karakterden Oluşabilir")
                .MaximumLength(100).WithMessage("Mesaj En Fazla 100 Karakterden Oluşabilir");

            RuleFor(contact => contact.ContactSubject)
                .NotEmpty().WithMessage("Başlık Boş Geçilemez")
                .MinimumLength(5).WithMessage("Başlık En Az 5 Karakterden Oluşabilir")
                .MaximumLength(20).WithMessage("Başlık En Fazla 20 Karakterden Oluşabilir");

            RuleFor(contact => contact.ContactUserName)
                .NotEmpty().WithMessage("Kullanıcı Adı Boş Geçilemez")
                .MinimumLength(3).WithMessage("Kullanıcı Adı En Az 3 Karakterden Oluşabilir")
                .MaximumLength(20).WithMessage("Kullanıcı Adı En Fazla 0 Karakterden Oluşabilir");


        }
    }
}
