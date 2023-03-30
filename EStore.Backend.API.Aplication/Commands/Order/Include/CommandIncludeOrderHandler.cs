using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace EStore.Backend.API.Aplication.Commands.Order.Include
{
    public class CommandIncludeOrderHandler : IRequestHandler<CommandIncludeOrder, CommandIncludeOrderResponse>
    {
        public CommandIncludeOrderHandler()
        {

        }

        public Task<CommandIncludeOrderResponse> Handle(CommandIncludeOrder request, CancellationToken cancellationToken)
        {
            throw new NotImplementedException();
        }
    }
}
