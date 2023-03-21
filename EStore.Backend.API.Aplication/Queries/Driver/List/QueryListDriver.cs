using EStore.Backend.API.Aplication.Enumerators;
using MediatR;
using MvcPaging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EStore.Backend.API.Aplication.Queries.Driver.List
{
    public class QueryListDriver : IRequest<IPagedList<QueryListDriverResponse>>
    {
        public int IdDriver { get; set; }

        public string Name { get; set; }

        public DriversLicenceType DriversLicenceType { get; set; }

        public DriversLicenceClass DriversLicenceClass { get; set; }

        public ContractType ContractType { get; set; }

        public EmployeeExperienceLevel EmployeeExperienceLevel { get; set; }

        public StatusService StatusService { get; set; }
    }
}
