using EStore.Backend.API.Aplication.Enumerators;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EStore.Backend.API.Aplication.Commands.Person.Change
{
    public class CommandChangePersonResponse
    {
        public int IdPerson { get; set; }

        public string Name { get; set; }

        public string SocialSecurityNumber { get; set; }

        public DateTime DateOfBrith { get; set; }

        public int Age { get; set; }

        public MaritalStatus MaritalStatus { get; set; }
    }
}
