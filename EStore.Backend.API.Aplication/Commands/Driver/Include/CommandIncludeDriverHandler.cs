using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace EStore.Backend.API.Aplication.Commands.Driver.Include
{
    public class CommandIncludeDriverHandler : IRequestHandler<CommandIncludeDriver, CommandIncludeDriverResponse>
    {
        public CommandIncludeDriverHandler()
        {

        }

        public Task<CommandIncludeDriverResponse> Handle(CommandIncludeDriver request, CancellationToken cancellationToken)
        {
            throw new NotImplementedException();
        }
    }
}
