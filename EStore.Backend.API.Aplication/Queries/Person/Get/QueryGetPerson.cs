using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EStore.Backend.API.Aplication.Queries.Person.Get
{
    public class QueryGetPerson : IRequest<List<QueryGetPersonResponse>>
    {
        public int IdPerson { get; set; }
    }
}
