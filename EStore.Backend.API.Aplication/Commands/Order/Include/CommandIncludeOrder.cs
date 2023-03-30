using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EStore.Backend.API.Aplication.Commands.Order.Include
{
    public class CommandIncludeOrder : IRequest<CommandIncludeOrderResponse>
    {
        public string Order { get; set; }

        public double Value { get; set; }

        public string Product { get; set; }

        public int Amount { get; set; }

        public string Description { get; set; }
    }
}
