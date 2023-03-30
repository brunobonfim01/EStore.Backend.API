using EStore.Backend.API.Aplication.Commands.Client.Change;
using EStore.Backend.API.Aplication.Commands.Client.Include;
using EStore.Backend.API.Aplication.Queries.Client.Get;
using EStore.Backend.API.Aplication.Queries.Client.List;
using MediatR;
using Microsoft.AspNetCore.Mvc;

namespace EStore.Backend.API.Controllers
{
    public class ClientController : Controller
    {
        private readonly IMediator _mediator;
        public ClientController(IMediator mediator)
        {
            _mediator = mediator;
        }

        [HttpPost]
        [Route("include/client")]
        public async Task<IActionResult> IncludeClients([FromBody] CommandIncludeClient command)
        {
            return Ok(await _mediator.Send(command));
        }

        [HttpPut]
        [Route("change/client")]
        public async Task<IActionResult> ChangeClients([FromQuery] CommandChangeClient command)
        {
            return Ok(await _mediator.Send(command));
        }

        [HttpGet]
        [Route("get/client")]
        public async Task<IActionResult> GetClients([FromQuery] QueryGetClient query)
        {
            return Ok(await _mediator.Send(query));
        }

        [HttpGet]
        [Route("list/client")]
        public async Task<IActionResult> ListClients([FromQuery] QueryListClient query)
        {
            return Ok(await _mediator.Send(query));
        }
    }
}
