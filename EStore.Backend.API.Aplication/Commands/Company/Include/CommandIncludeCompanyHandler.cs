using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace EStore.Backend.API.Aplication.Commands.Company.Include
{
    public class CommandIncludeCompanyHandler : IRequestHandler<CommandIncludeCompany, CommandIncludeCompanyResponse>
    {
        public CommandIncludeCompanyHandler()
        {

        }

        public Task<CommandIncludeCompanyResponse> Handle(CommandIncludeCompany request, CancellationToken cancellationToken)
        {
            throw new NotImplementedException();
        }
    }
}
