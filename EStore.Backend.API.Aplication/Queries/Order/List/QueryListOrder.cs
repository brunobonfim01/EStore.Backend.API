using MediatR;
using MvcPaging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EStore.Backend.API.Aplication.Queries.Order.List
{
    public class QueryListOrder : IRequest<IPagedList<QueryListOrderResponse>>
    {
        public string Order { get; set; }

        public double Value { get; set; }

        public string Product { get; set; }
    }
}
