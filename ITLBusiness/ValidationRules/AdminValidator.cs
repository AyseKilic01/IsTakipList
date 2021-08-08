using FluentValidation;
using ITLEntity.Concrete;

namespace ITLBusiness.ValidationRules
{
    public class AdminValidator : AbstractValidator<TblAdmin>
    {
        public AdminValidator()
        {
            RuleFor(x => x.username).NotEmpty().WithMessage("Kullanıcı Adı boş geçilemez ! ");
        }
    }
}
