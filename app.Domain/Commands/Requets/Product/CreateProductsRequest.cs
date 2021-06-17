using app.Domain.Commands.Responses;
using MediatR;

namespace app.Domain.Commands.Requests
{
    public class CreateProductRequest : IRequest<CreateProductResponse>
    {
        public decimal Price { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public int CategoryId { get; set; }
    }
}