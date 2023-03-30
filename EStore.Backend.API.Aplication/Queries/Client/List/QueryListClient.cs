using EStore.Backend.API.Aplication.Enumerators;
using EStore.Backend.API.Aplication.Interfaces;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EStore.Backend.API.Aplication.Queries.Client.List
{
    public class QueryListClient : IRequest<IPagedList<QueryListClientResponse>>
    {
        public string Name { get; set; }

        public string Adress { get; set; }

        public int NumberAdress { get; set; }

        public AdressType AdressType { get; set; }

        public string Email { get; set; }
    }
}
