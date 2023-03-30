using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EStore.Backend.API.Aplication.Queries.Company.List
{
    public class QueryListCompanyValidator : AbstractValidator<QueryListCompany>
    {
        public QueryListCompanyValidator()
        {
            RuleFor(c => c.Name)
               .MinimumLength(5)
               .MaximumLength(30);

            RuleFor(c => c.FantasyName)
                .MinimumLength(5)
                .MaximumLength(30);

            RuleFor(c => c.Adress)
                .MaximumLength(40);

            RuleFor(c => c.AdressType)
                .IsInEnum();

            RuleFor(c => c.Cep)
                .MaximumLength(7);

            RuleFor(c => c.Email)
                .NotNull()
                .EmailAddress();
        }
    }
}
