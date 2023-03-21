using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EStore.Backend.API.Aplication.Enumerators
{
    public enum VehicleType
    {
        [Description("Motorbike")]
        Motorbike = 0,
        [Description("Car")]
        Car = 1,
        [Description("Van")]
        Van = 2,
        [Description("PicapeTruck")]
        PicapeTruck = 3,
        [Description("Truck")]
        Truck = 4
    }
}
