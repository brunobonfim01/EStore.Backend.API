using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EStore.Backend.API.Aplication.Queries.Vehicle.List
{
    public class QueryListVehicleValidator : AbstractValidator<QueryListVehicle>
    {
        public QueryListVehicleValidator()
        {
            RuleFor(c => c.Model)
               .MinimumLength(3)
               .MaximumLength(30);

            RuleFor(c => c.Plate)
                .MaximumLength(7);

            RuleFor(c => c.Color)
                .MaximumLength(15);

            RuleFor(c => c.VehicleBrand)
                .IsInEnum();

            RuleFor(c => c.VehicleType)
                .IsInEnum();

            RuleFor(c => c.FleetNumber)
                .InclusiveBetween(1, 999);
        }
    }
}
