using EntityLayer.Concrete;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.ValidationRules
{
    public class CategoryValidator : AbstractValidator<Category>
    {
        public CategoryValidator()
        {
            RuleFor(c => c.CategoryName).NotEmpty().WithMessage("Kategori adını boş geçemezsiniz.");
            RuleFor(c => c.CategoryDescription).NotEmpty();
            RuleFor(c => c.CategoryName).MinimumLength(3).WithMessage("Lütfen en az 3 karakter girin.");
            

        }
    }
}
