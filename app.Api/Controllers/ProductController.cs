using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using app.Api.Data;
using app.Api.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace app.Api.Controllers
{

    [ApiController]
    [Route("v1/products")]
    public class ProductController : ControllerBase
    {
        
        [HttpGet]
        [Route("")]
        public async Task<ActionResult<List<Product>>> Get([FromServices] DataContext context)
        {
            var products = await context.Products.ToListAsync();
            return products;
        }

        [HttpGet]
        [Route("{id:int}")]
        public async Task<ActionResult<Product>> Get([FromServices] DataContext context, int id)
        {
            var product = await context.Products.Include(x => x.Category).AsNoTracking().FirstOrDefaultAsync(x => x.Id == id);
            return product;
        }

        [HttpGet]
        [Route("categories/{id:int}")]
        public async Task<ActionResult<List<Product>>> GetByCategory([FromServices] DataContext context, int id)
        {
            var product = await context.Products.Include(x => x.Category).AsNoTracking().Where(x => x.Category.Id == id).ToListAsync();
            return product;
        }

        [HttpPost]
        [Route("")]
        public async Task<ActionResult<Product>> Post([FromServices] DataContext context, [FromBody]Product product)
        {

            if(!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            context.Products.Add(product);
            await context.SaveChangesAsync();
            return product;
        }
    }
}