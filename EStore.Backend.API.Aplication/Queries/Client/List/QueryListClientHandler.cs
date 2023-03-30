using EStore.Backend.API.Aplication.Interfaces;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace EStore.Backend.API.Aplication.Queries.Client.List
{
    public class QueryListClientHandler : IRequestHandler<QueryListClient, IPagedList<QueryListClientResponse>>
    {
        public QueryListClientHandler()
        {

        }

        public Task<IPagedList<QueryListClientResponse>> Handle(QueryListClient request, CancellationToken cancellationToken)
        {
            throw new NotImplementedException();
        }
    }
}
