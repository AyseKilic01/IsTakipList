using FluentValidation;
using ITLEntity.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ITLBusiness.ValidationRules
{
    public class StatuValidator : AbstractValidator<Statu>
    {
        public StatuValidator()
        {
            RuleFor(x => x.isTask).NotEmpty().WithMessage("Görev boş geçilemez ! ");
        }
    }
}
