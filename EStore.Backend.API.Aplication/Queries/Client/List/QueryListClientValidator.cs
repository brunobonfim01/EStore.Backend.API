using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EStore.Backend.API.Aplication.Queries.Client.List
{
    public class QueryListClientValidator : AbstractValidator<QueryListClient>
    {
        public QueryListClientValidator()
        {
            RuleFor(c => c.Name)
              .MaximumLength(40);

            RuleFor(c => c.Adress)
                .MaximumLength(60);

            RuleFor(c => c.NumberAdress)
                .InclusiveBetween(1, 9999);

            RuleFor(c => c.AdressType)
                .IsInEnum();

            RuleFor(c => c.Email)
                .EmailAddress();
        }
    }
}
