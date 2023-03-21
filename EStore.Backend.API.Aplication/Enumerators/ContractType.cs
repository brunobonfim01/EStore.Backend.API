using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EStore.Backend.API.Aplication.Enumerators
{
    public enum ContractType
    {
        [Description("Internal_Employee")]
        Interna_lEmployee = 0,
        [Description("Outsourced_Employee")]
        Outsurced_Employee = 1,
        [Description("Self_Employee")]
        Self_Employee = 2,
        [Description("Partner")]
        Partner = 3
    }
}
