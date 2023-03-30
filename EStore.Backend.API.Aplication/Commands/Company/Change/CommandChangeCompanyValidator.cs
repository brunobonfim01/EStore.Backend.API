using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EStore.Backend.API.Aplication.Commands.Company.Change
{
    public class CommandChangeCompanyValidator : AbstractValidator<CommandChangeCompany>
    {
        public CommandChangeCompanyValidator()
        {
            RuleFor(c => c.IdCompany)
                .NotNull();

            RuleFor(c => c.Name)
               .NotEmpty()
               .MinimumLength(5)
               .MaximumLength(30);

            RuleFor(c => c.FantasyName)
                .MinimumLength(5)
                .MaximumLength(30);

            RuleFor(c => c.EmployerIdentificationNumber)
                .NotNull();

            RuleFor(c => c.Adress)
                .MaximumLength(40);

            RuleFor(c => c.AdressType)
                .IsInEnum();

            RuleFor(c => c.Number)
                .InclusiveBetween(1, 9999);

            RuleFor(c => c.Cep)
                .MaximumLength(7);

            RuleFor(c => c.Telephone)
                .MaximumLength(11);

            RuleFor(c => c.Cellphone)
                .MaximumLength(11);

            RuleFor(c => c.Email)
                .NotNull()
                .EmailAddress();
        }
    }
}
