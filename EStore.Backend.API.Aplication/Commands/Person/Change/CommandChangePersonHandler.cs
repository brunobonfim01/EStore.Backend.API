using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace EStore.Backend.API.Aplication.Commands.Person.Change
{
    public class CommandChangePersonHandler : IRequestHandler<CommandChangePerson, CommandChangePersonResponse>
    {
        public CommandChangePersonHandler()
        {

        }

        public Task<CommandChangePersonResponse> Handle(CommandChangePerson request, CancellationToken cancellationToken)
        {
            throw new NotImplementedException();
        }
    }
}
