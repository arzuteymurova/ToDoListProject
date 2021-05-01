using Entities.Concrete;
using FluentValidation;

namespace Business.ValidationRules.FluentValidation
{
    public class StatusValidator : AbstractValidator<Status>
    {
        public StatusValidator()
        {
            RuleFor(s => s.StatusName).NotEmpty();
            RuleFor(s => s.StatusName).MinimumLength(2);
        }
    }
}