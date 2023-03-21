using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace EStore.Backend.API.Aplication.Commands.Vehicle.Include
{
    public class CommandIncludeVehicleHandler : IRequestHandler<CommandIncludeVehicle, CommandIncludeVehicleResponse>
    {
        public CommandIncludeVehicleHandler()
        {

        }

        public Task<CommandIncludeVehicleResponse> Handle(CommandIncludeVehicle request, CancellationToken cancellationToken)
        {
            throw new NotImplementedException();
        }
    }
}

