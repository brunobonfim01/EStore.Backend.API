using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EStore.Backend.API.Aplication.Queries.Order.Get
{
    public class QueryGetOrder : IRequest<List<QueryGetOrderResponse>>
    {
        public int IdOrder { get; set; }
    }
}
