using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EStore.Backend.API.Aplication.Queries.Company.Get
{
    public class QueryGetCompany : IRequest<List<QueryGetCompanyResponse>>
    {
        public int IdCompany { get; set; }
    }
}
