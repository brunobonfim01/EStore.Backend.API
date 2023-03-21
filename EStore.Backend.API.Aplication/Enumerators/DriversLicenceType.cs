using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EStore.Backend.API.Aplication.Enumerators
{
    public enum DriversLicenceType
    {
        [Description("Standard")]
        Standard = 0,
        [Description("Special")]
        Special = 1,
        [Description("Commercial")]
        Commercial = 2,
        [Description("Provisional")]
        Provisional = 3
    }
}
