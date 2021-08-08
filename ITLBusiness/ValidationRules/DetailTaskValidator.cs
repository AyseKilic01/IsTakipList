using FluentValidation;
using ITLEntity.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ITLBusiness.ValidationRules
{
    public class DetailTaskValidator : AbstractValidator<TblDetailTask>
    {
        public DetailTaskValidator()
        {
            RuleFor(x => x.task).NotEmpty().WithMessage("Görev içeriği boş geçilemez ! ");
        }
    }
}
