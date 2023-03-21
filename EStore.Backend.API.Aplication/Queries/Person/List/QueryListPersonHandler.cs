using MediatR;
using MvcPaging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace EStore.Backend.API.Aplication.Queries.Person.List
{
    public class QueryListPersonHandler : IRequestHandler<QueryListPerson, IPagedList<QueryListPersonResponse>>
    {
        public QueryListPersonHandler()
        {

        }

        public Task<IPagedList<QueryListPersonResponse>> Handle(QueryListPerson request, CancellationToken cancellationToken)
        {
            throw new NotImplementedException();
        }
    }
}
