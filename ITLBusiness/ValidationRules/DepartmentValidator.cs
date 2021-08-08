using FluentValidation;
using ITLEntity.Concrete;

namespace ITLBusiness.ValidationRules
{
    public class DepartmentValidator : AbstractValidator<TblDepartment>
    {
        public DepartmentValidator()
        {
            RuleFor(x => x.departcode).NotEmpty().WithMessage("Departman Adı boş geçilemez ! ");
        }
    }
}
