using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace EStore.Backend.API.Aplication.Queries.Company.Get
{
    public class QueryGetCompanyHandler : IRequestHandler<QueryGetCompany, List<QueryGetCompanyResponse>>
    {
        public QueryGetCompanyHandler()
        {

        }

        public Task<List<QueryGetCompanyResponse>> Handle(QueryGetCompany request, CancellationToken cancellationToken)
        {
            throw new NotImplementedException();
        }
    }
}
