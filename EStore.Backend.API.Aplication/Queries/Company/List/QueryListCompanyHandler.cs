using MediatR;
using MvcPaging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace EStore.Backend.API.Aplication.Queries.Company.List
{
    public class QueryListCompanyHandler : IRequestHandler<QueryListCompany, IPagedList<QueryListCompanyResponse>>
    {
        public QueryListCompanyHandler()
        {

        }

        public Task<IPagedList<QueryListCompanyResponse>> Handle(QueryListCompany request, CancellationToken cancellationToken)
        {
            throw new NotImplementedException();
        }
    }
}
