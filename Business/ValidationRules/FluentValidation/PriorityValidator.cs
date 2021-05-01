using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entities.Concrete;
using FluentValidation;

namespace Business.ValidationRules.FluentValidation
{
    public class PriorityValidator:AbstractValidator<Priority>
    {
        public PriorityValidator()
        {
            RuleFor(p => p.PriorityName).NotEmpty();
            RuleFor(p => p.PriorityName).MinimumLength(2);
        }
    }
}
