using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EStore.Backend.API.Aplication.Queries.Vehicle.Get
{
    public class QueryGetVehicle : IRequest<List<QueryGetVehicleResponse>>
    {
        public int IdVehicle { get; set; }
    }
}
