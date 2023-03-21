using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EStore.Backend.API.Aplication.Queries.Person.List
{
    public class QueryListPersonValidator : AbstractValidator<QueryListPerson>
    {
        public QueryListPersonValidator()
        {
            RuleFor(c => c.Name)
             .MaximumLength(40);

            RuleFor(c => c.Age)
                .NotEmpty()
                .InclusiveBetween(18, 70);

            RuleFor(c => c.DateOfBirth)
                .NotNull();

            RuleFor(c => c.MaritalStatus)
                .IsInEnum();
        }
    }
}
