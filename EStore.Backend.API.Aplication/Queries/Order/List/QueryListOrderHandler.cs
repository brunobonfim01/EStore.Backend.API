using MediatR;
using MvcPaging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace EStore.Backend.API.Aplication.Queries.Order.List
{
    public class QueryListOrderHandler : IRequestHandler<QueryListOrder, IPagedList<QueryListOrderResponse>>
    {
        public QueryListOrderHandler()
        {

        }

        public Task<IPagedList<QueryListOrderResponse>> Handle(QueryListOrder request, CancellationToken cancellationToken)
        {
            throw new NotImplementedException();
        }
    }
}
