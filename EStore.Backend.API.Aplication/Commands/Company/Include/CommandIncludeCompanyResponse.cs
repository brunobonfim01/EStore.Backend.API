using EStore.Backend.API.Aplication.Enumerators;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EStore.Backend.API.Aplication.Commands.Company.Include
{
    public class CommandIncludeCompanyResponse
    {
        public int IdCompany { get; set; }

        public string Name { get; set; }

        public string FantasyName { get; set; }

        public int EmployerIdentificationNumber { get; set; }

        public string Adress { get; set; }

        public AdressType AdressType { get; set; }

        public int Number { get; set; }

        public string Cep { get; set; }

        public string Telephone { get; set; }

        public string Cellphone { get; set; }

        public string Email { get; set; }
    }
}
