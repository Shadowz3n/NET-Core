using Microsoft.AspNetCore.Mvc;
using MediatR;
using app.Domain.Commands.Responses;
using app.Domain.Commands.Requests;
using System.Threading.Tasks;

namespace app.Api.Controllers
{
    [Route("v1/customers")]
    public class CustomerController : ControllerBase
    {
        [HttpPost("")]
        public Task<CreateCustomerResponse> Create([FromServices] IMediator mediator, [FromBody] CreateCustomerRequest command) => mediator.Send(command);
    }
}