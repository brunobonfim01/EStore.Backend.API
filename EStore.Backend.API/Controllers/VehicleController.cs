using EStore.Backend.API.Aplication.Commands.Vehicle.Change;
using EStore.Backend.API.Aplication.Commands.Vehicle.Include;
using EStore.Backend.API.Aplication.Queries.Vehicle.Get;
using EStore.Backend.API.Aplication.Queries.Vehicle.List;
using MediatR;
using Microsoft.AspNetCore.Mvc;
//using System.Web.Mvc;

namespace EStore.Backend.API.Controllers
{
    public class VehicleController : Controller
    {
        private readonly IMediator _mediator;

        public VehicleController(IMediator mediator)
        {
            _mediator = mediator;
        }

        [HttpPost]
        [Route("include/vehicle")]
        public async Task<IActionResult> IncludeVehicles([FromBody] CommandIncludeVehicle command)
        {
            return Ok(await _mediator.Send(command));
        }

        [HttpPut]
        [Route("change/vehicle")]
        public async Task<IActionResult> ChangeVehicles([FromQuery] CommandChangeVehicle command)
        {
            return Ok(await _mediator.Send(command));
        }

        [HttpGet]
        [Route("get/vehicle")]
        public async Task<IActionResult> GetVehicles([FromQuery] QueryGetVehicle query)
        {
            return Ok(await _mediator.Send(query));
        }

        [HttpGet]
        [Route("list/vehicle")]
        public async Task<IActionResult> ListVehicles([FromQuery] QueryListVehicle query)
        {
            return Ok(await _mediator.Send(query));
        }
    }
}
