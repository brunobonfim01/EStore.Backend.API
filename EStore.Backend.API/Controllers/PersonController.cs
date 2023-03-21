using EStore.Backend.API.Aplication.Command.Person.Include;
using EStore.Backend.API.Aplication.Commands.Person.Change;
using EStore.Backend.API.Aplication.Queries.Person.Get;
using EStore.Backend.API.Aplication.Queries.Person.List;
using MediatR;
using Microsoft.AspNetCore.Mvc;
using MvcPaging;

namespace EStore.Backend.API.Controllers
{
    public class PersonController : Controller
    {
        private readonly IMediator _mediator;

        public PersonController(IMediator mediator)
        {
            _mediator = mediator;
        }

        [HttpPost]
        [Route("include/person")]
        public async Task<IActionResult> IncludePersons([FromBody] CommandIncludePerson command)
        {
            return Ok(await _mediator.Send(command));
        }

        [HttpPut]
        [Route("change/person")]
        public async Task<IActionResult> ChangePersons([FromQuery] CommandChangePerson command)
        {
            return Ok(await _mediator.Send(command));
        }

        [HttpGet]
        [Route("get/person")]
        public async Task<IActionResult> GetPersons([FromQuery] QueryGetPerson query)
        {
            return Ok(await _mediator.Send(query));
        }

        [HttpGet]
        [Route("list/person")]
        public async Task<IActionResult> ListPersons([FromQuery] QueryListPerson query)
        {
            return Ok(await _mediator.Send(query));
        }

    }
}
