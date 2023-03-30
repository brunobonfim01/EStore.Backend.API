using EStore.Backend.API.Aplication.Commands.Order.Change;
using EStore.Backend.API.Aplication.Commands.Order.Include;
using EStore.Backend.API.Aplication.Queries.Order.Get;
using EStore.Backend.API.Aplication.Queries.Order.List;
using MediatR;
using Microsoft.AspNetCore.Mvc;

namespace EStore.Backend.API.Controllers
{
    public class OrderController : Controller
    {
        private readonly IMediator _mediator;
        public OrderController(IMediator mediator)
        {
            _mediator = mediator;
        }

        [HttpPost]
        [Route("include/order")]
        public async Task<IActionResult> IncludeOrders([FromBody] CommandIncludeOrder command)
        {
            return Ok(await _mediator.Send(command));
        }

        [HttpPut]
        [Route("change/order")]
        public async Task<IActionResult> ChangeOrders([FromQuery] CommandChangeOrder command)
        {
            return Ok(await _mediator.Send(command));
        }

        [HttpGet]
        [Route("get/order")]
        public async Task<IActionResult> GetOrders([FromQuery] QueryGetOrder query)
        {
            return Ok(await _mediator.Send(query));
        }

        [HttpGet]
        [Route("list/order")]
        public async Task<IActionResult> ListOrders([FromQuery] QueryListOrder query)
        {
            return Ok(await _mediator.Send(query));
        }
    }
}
