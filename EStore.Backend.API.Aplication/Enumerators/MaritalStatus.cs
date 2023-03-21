using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EStore.Backend.API.Aplication.Enumerators
{
    public enum MaritalStatus
    {
        [Description("Single")]
        Single = 0,
        [Description("Married")]
        Married =1,
        [Description("Divorced")]
        Divorced = 2,
        [Description("Widower")]
        Widower = 3
    }
}
