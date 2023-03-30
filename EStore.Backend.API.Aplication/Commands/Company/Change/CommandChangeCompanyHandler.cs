using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace EStore.Backend.API.Aplication.Commands.Company.Change
{
    public class CommandChangeCompanyHandler : IRequestHandler<CommandChangeCompany, CommandChangeCompanyResponse>
    {
        public CommandChangeCompanyHandler()
        {

        }

        public Task<CommandChangeCompanyResponse> Handle(CommandChangeCompany request, CancellationToken cancellationToken)
        {
            throw new NotImplementedException();
        }
    }
}
