using EStore.Backend.API.Aplication.Enumerators;
using MediatR;
using MvcPaging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EStore.Backend.API.Aplication.Queries.Company.List
{
    public class QueryListCompany : IRequest<IPagedList<QueryListCompanyResponse>>
    {
        public string Name { get; set; }

        public string FantasyName { get; set; }

        public string Adress { get; set; }

        public AdressType AdressType { get; set; }

        public string Cep { get; set; }

        public string Email { get; set; }
    }
}
