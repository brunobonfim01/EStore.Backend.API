using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EStore.Backend.API.Aplication.Enumerators
{
    public enum EmployeeExperienceLevel
    {
        [Description("Intern")]
        Intern = 0,
        [Description("Trainee")]
        Trainee = 1,
        [Description("Junior")]
        Junior = 2,
        [Description("Full")]
        Full = 3,
        [Description("Senior")]
        Senior = 4
    }
}
