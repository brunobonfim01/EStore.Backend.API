using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EStore.Backend.API.Aplication.Commands.Vehicle.Change
{
    public class CommandChangeVehicleValidator : AbstractValidator<CommandChangeVehicle>
    {
        public CommandChangeVehicleValidator()
        {
            RuleFor(c => c.IdVehicle)
                .NotNull();

            RuleFor(c => c.Model)
                .NotEmpty()
                .MinimumLength(3)
                .MaximumLength(30);

            RuleFor(c => c.Plate)
                .NotEmpty()
                .MaximumLength(7);

            RuleFor(c => c.Color)
                .NotEmpty()
                .MaximumLength(15);

            RuleFor(c => c.VehicleBrand)
                .NotNull()
                .IsInEnum();

            RuleFor(c => c.VehicleType)
                .NotNull()
                .IsInEnum();

            RuleFor(c => c.FleetNumber)
                .NotEmpty()
                .InclusiveBetween(1, 999);
        }
    }
}
