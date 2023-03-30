using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace EStore.Backend.API.Aplication.Commands.Client.Include
{
    public class CommandIncludeClientHandler : IRequestHandler<CommandIncludeClient, CommandIncludeClientResponse>
    {
        public CommandIncludeClientHandler()
        {

        }

        public Task<CommandIncludeClientResponse> Handle(CommandIncludeClient request, CancellationToken cancellationToken)
        {
            throw new NotImplementedException();
        }
    }
}
