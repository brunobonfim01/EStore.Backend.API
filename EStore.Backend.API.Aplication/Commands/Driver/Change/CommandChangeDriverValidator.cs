using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EStore.Backend.API.Aplication.Commands.Driver.Change
{
    public class CommandChangeDriverValidator : AbstractValidator<CommandChangeDriver>
    {
        public CommandChangeDriverValidator()
        {
            RuleFor(c => c.IdDriver)
                .NotNull();

            RuleFor(c => c.Name)
               .NotEmpty()
               .MaximumLength(40);

            RuleFor(c => c.SocialSecurityNumber)
                .NotNull()
                .NotEmpty()
                .MaximumLength(9);

            RuleFor(c => c.DriversLicenceType)
                .NotEmpty()
                .IsInEnum();

            RuleFor(c => c.DriversLicenceClass)
                .NotEmpty()
                .IsInEnum();

            RuleFor(c => c.ContractType)
                .NotEmpty()
                .IsInEnum();

            RuleFor(c => c.EmployeeExperienceLevel)
                .NotEmpty()
                .IsInEnum();

            RuleFor(c => c.StatusService)
                .NotEmpty()
                .IsInEnum();
        }
    }
}
