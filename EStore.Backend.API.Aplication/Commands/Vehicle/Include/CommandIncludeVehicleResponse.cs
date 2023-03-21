using EStore.Backend.API.Aplication.Enumerators;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EStore.Backend.API.Aplication.Commands.Vehicle.Include
{
    public class CommandIncludeVehicleResponse
    {
        public int IdVehicle { get; set; }

        public string Model { get; set; }

        public string Plate { get; set; }

        public string Color { get; set; }

        public VehicleBrand VehicleBrand { get; set; }

        public VehicleType VehicleType { get; set; }

        public int FleetNumber { get; set; }
    }
}
