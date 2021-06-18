using MediatR;
using System.Linq;
using System.Threading.Tasks;
using app.Api.Data;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using app.Domain.Commands.Requests;

namespace app.Api.Controllers
{
    [ApiController]
    [Route("v1/products")]
    public class ProductController : ControllerBase
    {

        [HttpGet("")]
        public async Task<IActionResult> Get([FromServices] DataContext context)
        {
            var products = await context.Products.ToListAsync();
            return Ok(products);
        }

        [HttpGet("{id:int}")]
        public async Task<IActionResult> Get([FromServices] DataContext context, int id)
        {
            var product = await context.Products.Include(x => x.Category).AsNoTracking().FirstOrDefaultAsync(x => x.Id == id);
            return Ok(product);
        }

        [HttpGet("categories/{id:int}")]
        public async Task<IActionResult> GetByCategory([FromServices] DataContext context, int id)
        {
            var product = await context.Products.Include(x => x.Category).AsNoTracking().Where(x => x.Category.Id == id).ToListAsync();
            return Ok(product);
        }

        [HttpPost("")]
        public async Task<IActionResult> Post([FromServices] DataContext context, [FromServices] IMediator mediator, [FromBody] CreateProductRequest command) => Ok(await mediator.Send(command));

        // context.Products.Add(product);
        // await context.SaveChangesAsync();
        // return product;
    }
}