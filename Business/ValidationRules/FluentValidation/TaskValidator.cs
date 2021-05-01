using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Entities.Concrete;
using FluentValidation;

namespace Business.ValidationRules.FluentValidation
{
    public class TaskValidator:AbstractValidator<Task>
    {
        public TaskValidator()
        {
            RuleFor(t => t.TaskName).NotEmpty();
            RuleFor(t => t.TaskName).MinimumLength(2);
            RuleFor(t => t.StatusId).NotEmpty();
            RuleFor(t => t.PriorityId).NotEmpty();
            RuleFor(t => t.DueDate).NotEmpty();
            RuleFor(t => t.Details).NotEmpty();
            RuleFor(t => t.Details).MinimumLength(2);
        }
    }
}
