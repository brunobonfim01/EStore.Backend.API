using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace EStore.Backend.API.Aplication.Command.Person.Include
{
    public class CommandIncludePersonHandler : IRequestHandler< CommandIncludePerson, CommandIncludePersonResponse>
    {
        public CommandIncludePersonHandler()
        {

        }

        public Task<CommandIncludePersonResponse> Handle(CommandIncludePerson request, CancellationToken cancellationToken)
        {
            throw new NotImplementedException();
        }
    }
}
