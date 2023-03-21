using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace EStore.Backend.API.Aplication.Queries.Driver.Get
{
    public class QueryGetDriverHandler : IRequestHandler<QueryGetDriver, List<QueryGetDriverResponse>>
    {
        public QueryGetDriverHandler()
        {

        }

        public Task<List<QueryGetDriverResponse>> Handle(QueryGetDriver request, CancellationToken cancellationToken)
        {
            throw new NotImplementedException();
        }
    }
}
