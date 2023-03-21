using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EStore.Backend.API.Aplication.Queries.Driver.Get
{
    public class QueryGetDriver : IRequest<List<QueryGetDriverResponse>>
    {
        public int IdDriver { get; set; }
    }
}
