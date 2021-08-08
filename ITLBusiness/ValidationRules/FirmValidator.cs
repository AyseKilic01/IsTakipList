using ITLEntity.Concrete;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ITLBusiness.ValidationRules
{
   public class FirmValidator : AbstractValidator<Firm>
    {
        public FirmValidator()
        {
            RuleFor(x => x.city).NotEmpty().WithMessage("Şehir Adı boş geçilemez ! ");
        }
    }
}
