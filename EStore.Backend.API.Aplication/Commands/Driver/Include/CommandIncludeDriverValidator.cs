using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EStore.Backend.API.Aplication.Commands.Driver.Include
{
    public class CommandIncludeDriverValidator : AbstractValidator<CommandIncludeDriver>
    {
        public CommandIncludeDriverValidator()
        {
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
