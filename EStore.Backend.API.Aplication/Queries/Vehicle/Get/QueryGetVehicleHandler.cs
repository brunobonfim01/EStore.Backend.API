using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace EStore.Backend.API.Aplication.Queries.Vehicle.Get
{
    public class QueryGetVehicleHandler : IRequestHandler<QueryGetVehicle, List<QueryGetVehicleResponse>>
    {
        public QueryGetVehicleHandler()
        {

        }

        public Task<List<QueryGetVehicleResponse>> Handle(QueryGetVehicle request, CancellationToken cancellationToken)
        {
            throw new NotImplementedException();
        }
    }
}
