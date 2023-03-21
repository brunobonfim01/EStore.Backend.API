using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EStore.Backend.API.Aplication.Enumerators
{
    public enum AdressType
    {
        [Description("Main")]
        Main = 0,
        [Description("Branch")]
        Branch = 1
    }
}
