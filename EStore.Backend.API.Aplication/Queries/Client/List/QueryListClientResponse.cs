using EStore.Backend.API.Aplication.Enumerators;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EStore.Backend.API.Aplication.Queries.Client.List
{
    public class QueryListClientResponse
    {
        public int IdClient { get; set; }

        public string Name { get; set; }

        public string Adress { get; set; }

        public int NumberAdress { get; set; }

        public AdressType AdressType { get; set; }

        public string Email { get; set; }

        public DataPayment DataPayment { get; set; }
    }

    public class DataPayment
    {
        public string NumberCreditCard { get; set; }

        public int SecurityCode { get; set; }

        public FlagCard FlagCard { get; set; }

        public TypeCredtCard TypeCredtCard { get; set; }
    }
}
