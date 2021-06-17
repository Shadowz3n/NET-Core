using app.Domain.Commands.Responses;
using app.Domain.Commands.Requests;
using MediatR;
using System.Threading.Tasks;
using System.Threading;

namespace app.Domain.Commands.Handlers
{
    public class CreateCustumerHandler :
        IRequestHandler<CreateCustomerRequest, CreateCustomerResponse>
    {
        public Task<CreateCustomerResponse> Handle(CreateCustomerRequest request, CancellationToken cancellationToken)
        {
            var result = new CreateCustomerResponse
            {
                Name = request.Name,
                Email = request.Email
            };
            return Task.FromResult(result);
        }
    }
}