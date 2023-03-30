using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace EStore.Backend.API.Aplication.Queries.Client.Get
{
    public class QueryGetClientHandler : IRequestHandler<QueryGetClient, List<QueryGetClientResponse>>
    {
        public QueryGetClientHandler()
        {

        }

        public Task<List<QueryGetClientResponse>> Handle(QueryGetClient request, CancellationToken cancellationToken)
        {
            throw new NotImplementedException();
        }
    }
}
