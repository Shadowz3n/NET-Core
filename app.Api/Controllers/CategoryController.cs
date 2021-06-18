using System.Threading.Tasks;
using app.Api.Data;
using app.Api.Domain.Entities;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace app.Api.Controllers
{
    [ApiController]
    [Route("v1/categories")]
    public class CategoryController : ControllerBase
    {

        [HttpGet("")]
        public async Task<IActionResult> Get([FromServices] DataContext context)
        {
            var categories = await context.Categories.ToListAsync();
            return Ok(categories);
        }

        [HttpPost("")]
        public async Task<IActionResult> Post([FromServices] DataContext context, [FromBody] Category category)
        {
            if (!ModelState.IsValid)
                return BadRequest(ModelState);

            context.Categories.Add(category);
            await context.SaveChangesAsync();
            return Ok(category);
        }
    }
}