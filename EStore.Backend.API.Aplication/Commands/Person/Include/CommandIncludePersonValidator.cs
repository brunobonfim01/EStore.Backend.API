﻿using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EStore.Backend.API.Aplication.Command.Person.Include
{
    public class CommandIncludePersonValidator : AbstractValidator<CommandIncludePerson>
    {
        public CommandIncludePersonValidator()
        {
           RuleFor(c => c.Name)
                .NotEmpty()
                .MaximumLength(40);

            RuleFor(c => c.SocialSecurityNumber)
                .NotEmpty()
                .MaximumLength(9);

            RuleFor(c => c.Age)
                .NotEmpty()
                .NotNull()
                .InclusiveBetween(18, 70);

            RuleFor(c => c.DateOfBirth)
                .NotNull();

            RuleFor(c => c.MaritalStatus)
                .IsInEnum();
        }
    }
}
