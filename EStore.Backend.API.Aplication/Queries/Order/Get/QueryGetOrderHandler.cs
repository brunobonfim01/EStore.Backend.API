using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace EStore.Backend.API.Aplication.Queries.Order.Get
{
    public class QueryGetOrderHandler : IRequestHandler<QueryGetOrder, List<QueryGetOrderResponse>>
    {
        public QueryGetOrderHandler()
        {

        }

        public Task<List<QueryGetOrderResponse>> Handle(QueryGetOrder request, CancellationToken cancellationToken)
        {
            throw new NotImplementedException();
        }
    }
}
