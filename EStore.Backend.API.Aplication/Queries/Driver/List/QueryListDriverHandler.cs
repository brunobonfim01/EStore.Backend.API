using MediatR;
using MvcPaging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace EStore.Backend.API.Aplication.Queries.Driver.List
{
    public class QueryListDriverHandler : IRequestHandler<QueryListDriver, IPagedList<QueryListDriverResponse>>
    {
        public QueryListDriverHandler()
        {

        }

        public Task<IPagedList<QueryListDriverResponse>> Handle(QueryListDriver request, CancellationToken cancellationToken)
        {
            throw new NotImplementedException();
        }
    }
}
