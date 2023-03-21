using EStore.Backend.API.Aplication.Commands.Driver.Change;
using EStore.Backend.API.Aplication.Commands.Driver.Include;
using EStore.Backend.API.Aplication.Queries.Driver.Get;
using EStore.Backend.API.Aplication.Queries.Driver.List;
using MediatR;
using Microsoft.AspNetCore.Mvc;
//using System.Web.Mvc;

namespace EStore.Backend.API.Controllers
{
    public class DriverController : Controller
    {
        private readonly IMediator _mediator;
        public DriverController(IMediator mediator)
        {
            _mediator = mediator; 
        }

        [HttpPost]
        [Route("include/driver")]
        public async Task<IActionResult> IncludeDrivers([FromBody] CommandIncludeDriver command)
        {
            return Ok(await _mediator.Send(command));
        }

        [HttpPut]
        [Route("change/driver")]
        public async Task<IActionResult> ChangeDrivers([FromQuery] CommandChangeDriver command)
        {
            return Ok(await _mediator.Send(command));
        }

        [HttpGet]
        [Route("get/driver")]
        public async Task<IActionResult> GetDrivers([FromQuery] QueryGetDriver query)
        {
            return Ok(await _mediator.Send(query));
        }

        [HttpGet]
        [Route("list/driver")]
        public async Task<IActionResult> ListDrivers([FromQuery] QueryListDriver query)
        {
            return Ok(await _mediator.Send(query));
        }
    }
}
