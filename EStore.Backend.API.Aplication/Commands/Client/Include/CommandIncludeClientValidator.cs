using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EStore.Backend.API.Aplication.Commands.Client.Include
{
    public class CommandIncludeClientValidator : AbstractValidator<CommandIncludeClient>
    {
        public CommandIncludeClientValidator()
        {
            RuleFor(c => c.Name)
                .NotEmpty()
                .MaximumLength(40);

            RuleFor(c => c.Adress)
                .NotEmpty()
                .MaximumLength(60);

            RuleFor(c => c.NumberAdress)
                .NotEmpty()
                .InclusiveBetween(1, 9999);

            RuleFor(c => c.AdressType)
                .NotEmpty()
                .IsInEnum();

            RuleFor(c => c.Email)
                .NotEmpty()
                .EmailAddress();
        }
    }
}
