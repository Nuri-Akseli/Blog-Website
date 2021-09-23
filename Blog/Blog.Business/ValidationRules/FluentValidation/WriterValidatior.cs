using Blog.Business.Abstract;
using Blog.Entities.Concrete;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Blog.Business.ValidationRules.FluentValidation
{
    public class WriterValidatior:AbstractValidator<Writer>
    {
        IWriterService _writerService;
        public WriterValidatior(IWriterService writerService)
        {
            _writerService = writerService;


            RuleFor(writer => writer.WriterAbout)
                .NotEmpty().WithMessage("Hakkında Boş Geçilemez")
                .MaximumLength(150).WithMessage("Hakkında En Fazla 150 Karakterden Oluşabilir")
                .MinimumLength(5).WithMessage("Hakkında En Az 5 Karakterden Oluşabilir");

            RuleFor(writer => writer.WriterMail)
                .NotEmpty().WithMessage("Mail Boş Geçilemez")
                .EmailAddress().WithMessage("Mail Standartlarına Uygun Olmalıdır");

            RuleFor(writer => writer.WriterName)
                .NotEmpty().WithMessage("İsim Boş Geçilemez")
                .MinimumLength(2).WithMessage("İsim En Az 2 Karakterden Oluşabilir")
                .MaximumLength(20).WithMessage("İsim En Fazla 20 Karakterden Oluşabilir");

            RuleFor(writer => writer.WriterPassword)
                .NotEmpty().WithMessage("Şifre Boş Geçilemez")
                .Must(isEmailUnique).WithMessage("Email Sisteme Zaten Kayıtlı");
        }

        private bool isEmailUnique(string arg)
        {
            return _writerService.isEmailUnique(arg);
        }
    }
}
