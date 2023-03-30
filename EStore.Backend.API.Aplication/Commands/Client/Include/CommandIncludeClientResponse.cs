using EStore.Backend.API.Aplication.Enumerators;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EStore.Backend.API.Aplication.Commands.Client.Include
{
    public class CommandIncludeClientResponse
    {
        public int IdClient { get; set; }

        public string Name { get; set; }

        public string Adress { get; set; }

        public int NumberAdress { get; set; }

        public AdressType AdressType { get; set; }

        public string Email { get; set; }

        public DataPayment DataPayment { get; set; }
    }
}
