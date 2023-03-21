using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EStore.Backend.API.Aplication.Commands.Company.Include
{
    public class CommandIncludeCompanyValidator : AbstractValidator<CommandIncludeCompany>
    {
        public CommandIncludeCompanyValidator()
        {
            RuleFor(c => c.Name)
                .NotEmpty()
                .MinimumLength(5)
                .MaximumLength(30);

            RuleFor(c => c.FantasyName)
                .NotEmpty()
                .MinimumLength(5)
                .MaximumLength(30);

            RuleFor(c => c.EmployerIdentificationNumber)
                .NotEmpty()
                .NotNull();

            RuleFor(c => c.Adress)
                .NotEmpty()
                .MaximumLength(40);

            RuleFor(c => c.AdressType)
                .NotEmpty()
                .IsInEnum();

            RuleFor(c => c.Number)
                .NotEmpty()
                .InclusiveBetween(1, 9999);

            RuleFor(c => c.Cep)
                .NotEmpty()
                .MaximumLength(7);

            RuleFor(c => c.Telephone)
                .NotEmpty()
                .MaximumLength(11);

            RuleFor(c => c.Cellphone)
                .NotEmpty()
                .MaximumLength(11);

            RuleFor(c => c.Email)
                .NotEmpty()
                .NotNull()
                .EmailAddress();
        }
    }
}
