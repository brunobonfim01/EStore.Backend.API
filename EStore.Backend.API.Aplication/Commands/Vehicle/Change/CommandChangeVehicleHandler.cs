using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace EStore.Backend.API.Aplication.Commands.Vehicle.Change
{
    public class CommandChangeVehicleHandler : IRequestHandler<CommandChangeVehicle, CommandChangeVehicleResponse>
    {
        public CommandChangeVehicleHandler()
        {

        }

        public Task<CommandChangeVehicleResponse> Handle(CommandChangeVehicle request, CancellationToken cancellationToken)
        {
            throw new NotImplementedException();
        }
    }
}
