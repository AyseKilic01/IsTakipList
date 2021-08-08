using FluentValidation;
using ITLEntity.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ITLBusiness.ValidationRules
{
    public class EmployeeValidator : AbstractValidator<TblEmployee>
    {
        public EmployeeValidator()
        {
            RuleFor(x => x.name).NotEmpty().WithMessage("Personel Adı boş geçilemez ! ");
        }
    }
}
