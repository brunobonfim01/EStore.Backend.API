using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace EStore.Backend.API.Aplication.Commands.Driver.Change
{
    public class CommandChangeDriverHandler : IRequestHandler<CommandChangeDriver, CommandChangeDriverResponse>
    {
        public CommandChangeDriverHandler()
        {

        }

        public Task<CommandChangeDriverResponse> Handle(CommandChangeDriver request, CancellationToken cancellationToken)
        {
            throw new NotImplementedException();
        }
    }
}
