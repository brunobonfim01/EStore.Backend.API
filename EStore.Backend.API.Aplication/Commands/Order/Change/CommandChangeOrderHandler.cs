using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace EStore.Backend.API.Aplication.Commands.Order.Change
{
    public class CommandChangeOrderHandler : IRequestHandler<CommandChangeOrder, CommandChangeOrderResponse>
    {
        public CommandChangeOrderHandler()
        {

        }

        public Task<CommandChangeOrderResponse> Handle(CommandChangeOrder request, CancellationToken cancellationToken)
        {
            throw new NotImplementedException();
        }
    }
}
