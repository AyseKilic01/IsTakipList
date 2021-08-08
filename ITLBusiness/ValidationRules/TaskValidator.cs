using FluentValidation;
using ITLEntity.Concrete;

namespace ITLBusiness.ValidationRules
{
    public class TaskValidator : AbstractValidator<Tasks>
    {
        public TaskValidator()
        {
            RuleFor(x => x.commissioner).NotEmpty().WithMessage("Yönetici boş geçilemez ! ");
        }
    }
}
