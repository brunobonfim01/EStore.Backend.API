using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EStore.Backend.API.Aplication.Commands.Order.Change
{
    public class CommandChangeOrderValidator : AbstractValidator<CommandChangeOrder>
    {
        public CommandChangeOrderValidator()
        {
            RuleFor(c => c.Order)
                .NotNull()
                .MaximumLength(16);

            RuleFor(c => c.Value)
                .NotNull();

            RuleFor(c => c.Product)
                .NotNull()
                .MaximumLength(60);

            RuleFor(c => c.Amount)
                .InclusiveBetween(1, 9999);

            RuleFor(c => c.Description)
                .MaximumLength(200);
        }
    }
}
