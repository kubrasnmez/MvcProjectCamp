using EntityLayer.Concrete;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.ValidationRules
{
    public class WriterValidator : AbstractValidator<Writer>
    {
        public WriterValidator()
        {
            RuleFor(w => w.WriterName).NotEmpty().WithMessage("Yazar adını boş geçemezsiniz.");
            RuleFor(w => w.WriterSurName).NotEmpty().WithMessage("Yazar soyadını boş geçemezsiniz.");
            RuleFor(w => w.WriterAbout).NotEmpty().WithMessage("Hakkındayı boş geçemezsiniz.");
            RuleFor(w => w.WriterName).MinimumLength(2).WithMessage("Lütfen en az iki karakter giriş yapınız.");
            //RuleFor(w => w.WriterAbout).Must(ContainsTheA).WithMessage("Lütfen a harfi içeren bir metin girin.");
        }
        private bool ContainsTheA(string arg)
        {
            return arg.Contains("a") || arg.Contains("A");
        }
    }
}
