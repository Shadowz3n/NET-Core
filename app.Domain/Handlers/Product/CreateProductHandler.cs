using app.Domain.Commands.Responses;
using app.Domain.Commands.Requests;
using MediatR;
using System.Threading.Tasks;
using System.Threading;

namespace app.Domain.Commands.Handlers
{
    public class CreateProductHandler :
        IRequestHandler<CreateProductRequest, CreateProductResponse>
    {
        public Task<CreateProductResponse> Handle(CreateProductRequest request, CancellationToken cancellationToken)
        {
            var result = new CreateProductResponse
            {

            };
            return Task.FromResult(result);
        }
    }
}