using app.Domain.Commands.Responses;
using app.Domain.Commands.Requests;

namespace app.Domain.Commands.Handlers
{
    public class CreateCustumerHandler
    {
        public CreateCustumerResponse Handler(CreateCustumerRequest request)
        {
            return new CreateCustumerResponse
            {
                Name = request.Name,
                Email = request.Email
            };
        }
    }
}