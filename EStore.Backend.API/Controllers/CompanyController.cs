using EStore.Backend.API.Aplication.Commands.Company.Change;
using EStore.Backend.API.Aplication.Commands.Company.Include;
using EStore.Backend.API.Aplication.Queries.Company.Get;
using EStore.Backend.API.Aplication.Queries.Company.List;
using MediatR;
using Microsoft.AspNetCore.Mvc;

namespace EStore.Backend.API.Controllers
{
    public class CompanyController : Controller
    {
        private readonly IMediator _mediator;
        public CompanyController(IMediator mediator)
        {
            _mediator = mediator; 
        }

        [HttpPost]
        [Route("include/company")]
        public async Task<IActionResult> IncludeCompanys([FromBody] CommandIncludeCompany command)
        {
            return Ok(await _mediator.Send(command));
        }

        [HttpPut]
        [Route("change/company")]
        public async Task<IActionResult> ChangeCompanys([FromQuery] CommandChangeCompany command)
        {
            return Ok(await _mediator.Send(command));
        }

        [HttpGet]
        [Route("get/company")]
        public async Task<IActionResult> GetCompanys([FromQuery] QueryGetCompany query)
        {
            return Ok(await _mediator.Send(query));
        }

        [HttpGet]
        [Route("list/company")]
        public async Task<IActionResult> ListCompanys([FromQuery] QueryListCompany query)
        {
            return Ok(await _mediator.Send(query));
        }
    }
}
