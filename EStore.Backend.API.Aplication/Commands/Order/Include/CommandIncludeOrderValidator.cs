using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EStore.Backend.API.Aplication.Commands.Order.Include
{
    public class CommandIncludeOrderValidator : AbstractValidator<CommandIncludeOrder>
    {
        public CommandIncludeOrderValidator()
        {
            RuleFor(c => c.Order)
                .NotEmpty()
                .NotNull()
                .MaximumLength(16);

            RuleFor(c => c.Value)
                .NotEmpty()
                .NotNull();

            RuleFor(c => c.Product)
                .NotNull()
                .MaximumLength(60);

            RuleFor(c => c.Amount)
                .NotEmpty()
                .InclusiveBetween(1, 9999);

            RuleFor(c => c.Description)
                .MaximumLength(200);
        }
    }
}
