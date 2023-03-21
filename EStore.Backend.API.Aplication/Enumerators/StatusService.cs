using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EStore.Backend.API.Aplication.Enumerators
{
    public enum StatusService
    {
        [Description("Active")]
        Active = 0,
        [Description("OnHold")]
        OnHold = 1,
        [Description("Disable")]
        Disable = 2
    }
}
