using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace EStore.Backend.API.Aplication.Queries.Person.Get
{
    public class QueryGetPersonHandler : IRequestHandler<QueryGetPerson, List<QueryGetPersonResponse>>
    {
        public QueryGetPersonHandler()
        {

        }

        public Task<List<QueryGetPersonResponse>> Handle(QueryGetPerson request, CancellationToken cancellationToken)
        {
            throw new NotImplementedException();
        }
    }
}
