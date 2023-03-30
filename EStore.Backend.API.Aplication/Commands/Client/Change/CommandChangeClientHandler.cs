using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace EStore.Backend.API.Aplication.Commands.Client.Change
{
    public class CommandChangeClientHandler : IRequestHandler<CommandChangeClient, CommandChangeClientResponse>
    {
        public CommandChangeClientHandler()
        {

        }

        public Task<CommandChangeClientResponse> Handle(CommandChangeClient request, CancellationToken cancellationToken)
        {
            throw new NotImplementedException();
        }
    }
}
