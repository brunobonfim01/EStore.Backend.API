﻿using EStore.Backend.API.Aplication.Enumerators;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EStore.Backend.API.Aplication.Queries.Person.Get
{
    public class QueryGetPersonResponse
    {
        public int IdPerson { get; set; }

        public string Name { get; set; }

        public string SocialSecurityNumber { get; set; }

        public DateTime DateOfBirth { get; set; }

        public int Age { get; set; }

        public MaritalStatus MaritalStatus { get; set; }
    }
}
