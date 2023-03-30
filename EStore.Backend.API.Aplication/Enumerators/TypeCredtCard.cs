using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EStore.Backend.API.Aplication.Enumerators
{
    public enum TypeCredtCard
    {
        [Description("National")]
        National = 0,
        [Description("International")]
        International = 1,
    }
}
