using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EStore.Backend.API.Aplication.Enumerators
{
    public enum VehicleBrand
    {
        [Description("Ford")]
        Ford = 0,
        [Description("Chevrolet")]
        Chevrolet = 1,
        [Description("VolksWagem")]
        VolksWagem = 2,
        [Description("GMC")]
        GMC = 3,
        [Description("Scania")]
        Scania = 4,
        [Description("Peugeot")]
        Peugeot = 5,
        [Description("Critroen")]
        Citroen = 6,
        [Description("Fiat")]
        Fiat = 7,
        [Description("Honda")]
        Honda = 8,
        [Description("Toyota")]
        Toyota = 9,
        [Description("Hyndai")]
        Hyundai = 10,
        [Description("Dodge")]
        Dodge = 11,
        [Description("MercedesBens")]
        MercedesBens = 12
    }
}
