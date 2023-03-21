using MediatR;
using MvcPaging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace EStore.Backend.API.Aplication.Queries.Vehicle.List
{
    public class QueryListVehicleHandler : IRequestHandler<QueryListVehicle, IPagedList<QueryListVehicleResponse>>
    {
        public QueryListVehicleHandler()
        {

        }

        public Task<IPagedList<QueryListVehicleResponse>> Handle(QueryListVehicle request, CancellationToken cancellationToken)
        {
            throw new NotImplementedException();
        }
    }
}
