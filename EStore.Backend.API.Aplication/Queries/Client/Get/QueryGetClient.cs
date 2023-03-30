using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EStore.Backend.API.Aplication.Queries.Client.Get
{
    public class QueryGetClient : IRequest<List<QueryGetClientResponse>>
    {
        public int IdClient { get; set; }
    }
}
