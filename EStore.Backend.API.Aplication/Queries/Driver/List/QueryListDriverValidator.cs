using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EStore.Backend.API.Aplication.Queries.Driver.List
{
    public class QueryListDriverValidator : AbstractValidator<QueryListDriver>
    {
        public QueryListDriverValidator()
        {
            RuleFor(c => c.Name)
               .MaximumLength(40);

            RuleFor(c => c.DriversLicenceType)
                .IsInEnum();

            RuleFor(c => c.DriversLicenceClass)
                .IsInEnum();

            RuleFor(c => c.ContractType)
                .IsInEnum();

            RuleFor(c => c.EmployeeExperienceLevel)
                .IsInEnum();

            RuleFor(c => c.StatusService)
                .IsInEnum();
        }
    }
}
